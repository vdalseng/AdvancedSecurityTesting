using DatastreamApi.Services;
using DatastreamApi.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IWelcomeService, WelcomeService>();

var app = builder.Build();

app.MapGet("/", async (IWelcomeService welcomeService1, IWelcomeService welcomeService2) => 
{
    var message1 = await Task.Run(() => welcomeService1.GetWelcomeMessage());
    var message2 = await Task.Run(() => welcomeService2.GetWelcomeMessage());
    return $"Message1: {message1}\nMessage2: {message2}";
});

app.Run();
