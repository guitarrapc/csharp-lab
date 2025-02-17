using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DatabaseCore.Models;
using System.Reflection;

namespace DatabaseMySqlEf;

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
        var conn = config.GetConnectionString("Default");
        var optionsBuilder = new DbContextOptionsBuilder<BloggingDbContext>();
        optionsBuilder.UseMySql(conn, new MySqlServerVersion(new Version(8, 0)), options =>
        {
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });

        return new BloggingDbContext(optionsBuilder.Options);
    }
}
