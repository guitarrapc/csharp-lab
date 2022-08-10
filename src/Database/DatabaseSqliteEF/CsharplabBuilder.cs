using DatabaseCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace DatabaseSqliteEf;
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
        var dbPath = Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().Location)!.FullName, "Blogging.db");
        // Wants use IDbContextFactory instead of DbContext.
        builder.Services.AddDbContextFactory<BloggingDbContext>(optionBuilder =>
        {
            optionBuilder.UseSqlite($"Data Source={dbPath}");
#if DEBUG
            optionBuilder.EnableSensitiveDataLogging();
#endif
        });

        return builder;
    }
}
