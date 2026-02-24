using WeatherAppTest.Models;
using WeatherService;
using WeatherService.ServiceContracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IWeatherService, WeatherService.WeatherService>();


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
