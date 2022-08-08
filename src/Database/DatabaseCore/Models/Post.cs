using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DatabaseCore.Models;
public class Post
{
    [Key]
    public int PostId { get; set; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;

    public int BlogId { get; set; }
    public Blog Blog { get; set; } = default!;
}

public class PostRepository : RepositoryBase
{
    public PostRepository(BloggingDbContext context) : base(context) { }

    public async Task<IReadOnlyList<Post>> AllPostsAsync(CancellationToken ct)
    {
        return await Context.Posts.ToArrayAsync(ct);
    }

    public async Task<IReadOnlyList<Post>> GetPostsAsync(int blogId, CancellationToken ct)
    {
        return await Context.Posts.Where(x => x.BlogId == blogId).ToArrayAsync(ct);
    }

    public async Task<Post?> GetPostAsync(int blogId, int postId, CancellationToken ct)
    {
        return Context.Posts
            .Where(x => x.BlogId == blogId)
            .Where(x => x.PostId == postId)
            .FirstOrDefault();
    }

    public async Task<Post?> GetLastPostAsync(int blogId, CancellationToken ct)
    {
        return await Context.Posts.Where(x => x.BlogId == blogId).OrderBy(x => x.PostId).LastOrDefaultAsync(ct);
    }

    public async Task AddPostAsync(Post post, CancellationToken ct)
    {
        await Context.Posts.AddAsync(post, ct);
        await Context.SaveChangesAsync(ct);
    }

    public async Task DeletePostAsync(Post post, CancellationToken ct)
    {
        Context.Posts.Remove(post);
        await Context.SaveChangesAsync(ct);
    }

    public async Task DeletePostsAsync(IReadOnlyList<Post> post, CancellationToken ct)
    {
        Context.Posts.RemoveRange(post);
        await Context.SaveChangesAsync(ct);
    }

    public async Task UpdatePostAsync(Post post, CancellationToken ct)
    {
        Context.Posts.Update(post);
        await Context.SaveChangesAsync(ct);
    }
}
