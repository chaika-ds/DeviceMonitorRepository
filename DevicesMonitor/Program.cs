using DevicesMonitor.Controllers;
using DevicesMonitor.Extensions;
using static System.Threading.Tasks.Task;

var appBuilder = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.RegisterAppServices();
        });

var host = appBuilder.Build();
using var scope = host.Services.CreateScope();

WhenAll(scope.ServiceProvider.GetRequiredService<MonitorController>().MonitorDevice(3));

Console.ReadKey();

Environment.Exit(0);