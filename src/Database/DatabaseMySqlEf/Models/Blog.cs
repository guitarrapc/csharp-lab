using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseMySqlEf.Models;

public class Blog
{
    [Key]
    public int BlogId { get; set; }
    public string Url { get; set; } = default!;
    public List<Post> Posts { get; } = new();
}

public class BlogRepository : RepositoryBase
{
    public BlogRepository(BloggingDbContext context) : base(context) { }

    public async Task<IReadOnlyList<Blog>> AllBlogsAsync(CancellationToken ct)
    {
        return await Context.Blogs.ToArrayAsync();
    }

    public async Task<Blog?> GetBlogAsync(int blogId, CancellationToken ct)
    {
        return Context.Blogs
            .Where(x => x.BlogId == blogId)
            .FirstOrDefault();
    }

    public async Task<Blog?> GetLastBlogAsync(CancellationToken ct)
    {
        return await Context.Blogs.OrderBy(x => x.BlogId).LastOrDefaultAsync(ct);
    }

    public async Task AddBlogAsync(Blog blog, CancellationToken ct)
    {
        await Context.Blogs.AddAsync(blog, ct);
        await Context.SaveChangesAsync(ct);
    }

    public async Task DeleteBlogAsync(Blog blog, CancellationToken ct)
    {
        Context.Blogs.Remove(blog);
        var postRepository = new PostRepository(Context);
        var posts = await postRepository.GetPostsAsync(blog.BlogId, ct);
        Context.Blogs.Remove(blog);

        if (posts.Count != 0)
        {
            await postRepository.DeletePostsAsync(posts, ct);
        }

        await Context.SaveChangesAsync(ct);
    }

    public async Task DeleteBlogsAsync(IReadOnlyList<Blog> blogs, CancellationToken ct)
    {
        foreach (var blog in blogs)
        {
            await DeleteBlogAsync(blog, ct);
        }
    }

    public async Task UpdateBlogAsync(Blog blog, CancellationToken ct)
    {
        Context.Blogs.Update(blog);
        await Context.SaveChangesAsync(ct);
    }
}
