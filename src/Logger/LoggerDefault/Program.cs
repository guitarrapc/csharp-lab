using LoggerDefault;
using System.Text.Json;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<LogMessageWorker>();
    })
    .Build();

await host.RunAsync();
