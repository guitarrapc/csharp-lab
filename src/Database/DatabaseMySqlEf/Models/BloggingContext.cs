using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DatabaseMySqlEf.Models;
public class BloggingDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; init; } = default!;
    public DbSet<Post> Posts { get; init; } = default!;

    public BloggingDbContext() { }
    public BloggingDbContext(DbContextOptions<BloggingDbContext> options) : base(options)
    {
        // via DI AddDbContext/AddDbContextFactory
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Map table names
        modelBuilder.Entity<Blog>().ToTable("blog");
        //modelBuilder.Entity<Post>().ToTable("post");
        base.OnModelCreating(modelBuilder);
    }

    public BlogRepository GetUserRepository() => new(this);
}

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
        optionsBuilder.UseMySql("Server=localhost;Database=foo;user=user;password=password111;", new MySqlServerVersion(new Version(8, 0)), options =>
        {
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });

        return new BloggingDbContext(optionsBuilder.Options);
    }
}
