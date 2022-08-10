using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using DatabaseCore.Models;
using System.Reflection;

namespace DatabaseSqliteInmemoryEF;

// Context for Designtime. see https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
// Only used when `dotnet ef migrations add FooBase`.
public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingDbContext>
{
    public BloggingDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BloggingDbContext>();
        optionsBuilder.UseSqlite($"Data Source=Blogging;Mode=Memory;Cache=Shared", options =>
        {
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });

        return new BloggingDbContext(optionsBuilder.Options);
    }
}
