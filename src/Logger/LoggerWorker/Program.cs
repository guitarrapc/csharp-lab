using LoggerWorker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<LogMessageSourceGenerator>();
    })
    .Build();

await host.RunAsync();
