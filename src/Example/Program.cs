using CommandLineParser.Builders;

var builder = WebApplication
	.CreateBuilder()
	.WithArguments<IMyArguments, MyArguments>(args);
builder.Services.AddHostedService<ExampleService>();
var app = builder.Build();
app.Run();