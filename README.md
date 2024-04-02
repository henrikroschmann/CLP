# CLP
Command Line parser 

 A flexible command-line argument parsing library for ASP.NET Core applications, supporting custom properties and service configuration via parsed arguments.


# Usage

1. Define an interface and a class for your arguments:
```csharp
public class MyArguments : IMyArguments
{
    [Argument(nameof(Hello), "hi", "Hello Message")]
    public string Hello { get; set; }

    [Argument(nameof(Work), "w", "Work Description")]
    public string Work { get; set; }

    [Argument(nameof(Bye), "b", "Goodbye message")]
    public string Bye { get; set; }
}
```

```csharp
public interface IMyArguments : IArguments
{
    string Hello { get; set; }
    string Work { get; set; }
    string Bye { get; set; }
}
``` 

2. Use the WithArguments extension:
```csharp
var builder = WebApplication
    .CreateBuilder()
    .WithArguments<IMyArguments, MyArguments>(args);
```

3. Access arguments in middleware or services:
```csharp
public class MyMiddleware 
{
    private readonly IArguments _arguments;

    public MyMiddleware(IArguments arguments) { ... } 
}
```
