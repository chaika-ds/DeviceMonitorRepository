using DevicesMonitor.Controllers;

namespace DevicesMonitor.Extensions;

/// <summary>
/// Extensions for ServiceCollection
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register services for Eaton project
    /// </summary>
    /// <param name="services">IServiceCollection</param>
    public static void RegisterAppServices(this IServiceCollection services)
    {
        services.AddTransient<MonitorController>();
    }
}