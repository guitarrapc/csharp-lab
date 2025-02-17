using DatabaseCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DatabasePostgresqlEf;

// Context for Designtime. see https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingDbContext>
{
    public BloggingDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddJsonFile("appsettings.Development.json", true)
            .AddCommandLine(args)
            .AddEnvironmentVariables()
            .Build();
        var conn = config.GetConnectionString("Default") ?? throw new ArgumentNullException($"Default ConnectionString not found.");
        var optionsBuilder = new DbContextOptionsBuilder<BloggingDbContext>();
        optionsBuilder.UseNpgsql(conn, options =>
        {
            options.SetPostgresVersion(14, 0);
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });

        return new BloggingDbContext(optionsBuilder.Options);
    }
}
