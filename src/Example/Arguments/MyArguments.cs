namespace Example.Arguments;

public class MyArguments : IMyArguments
{
    [Argument(nameof(Hello), "hi", "Hello Message")]
    public string Hello { get; set; }

    [Argument(nameof(Work), "w", "Work Description")]
    public string Work { get; set; }

    [Argument(nameof(Bye), "b", "Goodbye message")]
    public string Bye { get; set; }
}