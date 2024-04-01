namespace Example;

public class ExampleService : IHostedService
{
    private readonly IMyArguments _myArguments;

    public ExampleService(IMyArguments myArguments)
    {
        _myArguments = myArguments;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine(_myArguments.Hello);
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}