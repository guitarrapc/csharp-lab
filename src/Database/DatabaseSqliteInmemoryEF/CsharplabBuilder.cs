using DatabaseCore.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

namespace DatabaseSqliteInmemoryEF;
public interface ICsharplabBuilder
{
    IServiceCollection Services { get; }
    IConfiguration Configuration { get; }
}

public class CsharplabBuilder : ICsharplabBuilder
{
    public IServiceCollection Services { get; }
    public IConfiguration Configuration { get; }

    public CsharplabBuilder(IServiceCollection services, IConfiguration configuration)
    {
        Services = services ?? throw new ArgumentNullException(nameof(services));
        Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }
}

public static class CsharplabBuilderExtensions
{
    /// <summary>
    /// Add Application specific DI for Model
    /// </summary>
    /// <param name="builder"></param>
    public static ICsharplabBuilder AddCsharpLabService(this IServiceCollection services, IConfiguration configuration)
    {
        return new CsharplabBuilder(services, configuration)
            .AddCsharpServices()
            .AddCsharpLabHostedServices()
            .AddCsharpLabDatabase();
    }

    /// <summary>
    /// Add Application Model to DI.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    private static ICsharplabBuilder AddCsharpServices(this ICsharplabBuilder builder)
    {
        builder.Services.AddSingleton<BlogModel>();

        return builder;
    }

    /// <summary>
    /// Add Application IHostedService to DI
    /// </summary>
    /// <param name="builder"></param>
    private static ICsharplabBuilder AddCsharpLabHostedServices(this ICsharplabBuilder builder)
    {
        builder.Services.AddHostedService<BackgroundHostedService>();

        return builder;
    }

    /// <summary>
    /// Add Application Database to DI
    /// </summary>
    /// <param name="builder"></param>
    public static ICsharplabBuilder AddCsharpLabDatabase(this ICsharplabBuilder builder)
    {
        var connectionString = $"Data Source=Blogging;Mode=Memory;Cache=Shared;";
        var conn = new SqliteConnection(connectionString);
        conn.Open(); // Don't use directly. Inmemory Sqlite will deleted when all connection closed. Lets keep this connection for Migration and App. 

        // Wants use IDbContextFactory instead of DbContext.
        builder.Services.AddDbContextFactory<BloggingDbContext>(optionBuilder =>
        {
            _ = conn; // capture master connection
            optionBuilder.UseSqlite(connectionString);
#if DEBUG
            optionBuilder.EnableSensitiveDataLogging();
#endif
        });

        builder.Services.AddHostedService<DatabaseInitializeHostedService>();

        return builder;
    }
}

public class DatabaseInitializeHostedService : IHostedService
{
    public DatabaseInitializeHostedService(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        scope.ServiceProvider.GetRequiredService<BloggingDbContext>().Database.EnsureCreated();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
