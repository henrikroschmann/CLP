namespace CommandLineParser;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder WithArguments<T1, T2>(
        this WebApplicationBuilder builder,
        string[] args) where T1 : class, IArguments where T2 : T1, new()
    {
        var argumentParser = new T2();
        ParseArguments(argumentParser, args);
        builder.Services.AddSingleton<T1>(argumentParser);
        return builder;
    }

    private static void ParseArguments<T>(T argumentParser, string[] args)
    {
        var dict = new Dictionary<string, string>();
        try
        {
            for (int i = 0; i < args.Length; i += 2)
            {
                dict.Add(args[i], args[i + 1]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Incorrect use of command lines arguments");
            throw;
        }
        var properties = typeof(T).GetProperties();
        foreach (var property in properties)
        {
            var attr = property.GetCustomAttributes(true);
            dict.TryGetValue($"-{((Argument)attr[0]).key}", out var data);
            if (string.IsNullOrEmpty(data)) continue;
            property.SetValue(argumentParser, data);
        }
    }
}