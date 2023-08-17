
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Interfaces;

public class RegisterServices
{
    public static IServiceCollection ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IWeatherService, WeatherService>();
        // Add more service registrations here

        return services;
    }
}