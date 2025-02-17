using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using DatabaseCore.Models;
using System.Reflection;

namespace DatabaseSqliteEf;

// Context for Designtime. see https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingDbContext>
{
    public BloggingDbContext CreateDbContext(string[] args)
    {
        var dbPath = Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().Location)!.FullName, "Blogging.db");
        var optionsBuilder = new DbContextOptionsBuilder<BloggingDbContext>();
        optionsBuilder.UseSqlite($"Data Source={dbPath}", options =>
        {
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });

        return new BloggingDbContext(optionsBuilder.Options);
    }
}
