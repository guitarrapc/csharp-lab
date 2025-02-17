using Microsoft.EntityFrameworkCore;

namespace DatabaseCore.Models;
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
