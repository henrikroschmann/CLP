var builder = WebApplication
    .CreateBuilder()
    .WithArguments<IArguments, MyArguments>(args);
builder.Services.AddHostedService<ExampleService>();
var app = builder.Build();
app.Run();