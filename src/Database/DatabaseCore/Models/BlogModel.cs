using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatabaseCore.Models;

public class BlogModel
{
    private readonly ILogger<BlogModel> _logger;
    private readonly IDbContextFactory<BloggingDbContext> _dbFactory;

    public BlogModel(ILogger<BlogModel> logger, IDbContextFactory<BloggingDbContext> dbFactory)
    {
        _logger = logger;
        _dbFactory = dbFactory;
    }

    /// <summary>
    /// Get existing record or add new.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<Blog> GetOrAddBlogAsync(CancellationToken ct)
    {
        await using var db = await _dbFactory.CreateDbContextAsync(ct);
        var blogRepository = new BlogRepository(db);
        var lastBlog = await blogRepository.GetLastBlogAsync(ct);
        if (lastBlog is not null)
        {
            return lastBlog;
        }

        var blogId = 1;
        var blog = new Blog
        {
            BlogId = blogId,
            Url = $"https://example.com/{blogId}",
        };
        await using (var transaction = await db.BeginTransactionAsync(ct))
        {
            await blogRepository.AddBlogAsync(blog, ct);
            await transaction.CommitAsync(ct);
        }

        return blog;
    }

    /// <summary>
    /// Add Post
    /// </summary>
    /// <param name="blogId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task AddPostAsync(int blogId, CancellationToken ct)
    {
        _logger.LogDebug("Adding Post");
        await using var db = await _dbFactory.CreateDbContextAsync(ct);
        var postRepostiory = new PostRepository(db);

        // Add Post
        var lastPost = await postRepostiory.GetLastPostAsync(blogId, ct);
        var postId = lastPost is not null ? 1 + lastPost.PostId : 1;
        var post = new Post
        {
            PostId = postId,
            Title = $"{blogId}-{postId}: Nantoka {Guid.NewGuid().ToString()}",
            Content = "foo\nbar",
            BlogId = blogId,
        };

        await using (var transaction = await db.BeginTransactionAsync(ct))
        {
            await postRepostiory.AddPostAsync(post, ct);
            await transaction.CommitAsync(ct);
        }
    }

    public async Task<IReadOnlyList<Blog>> GetAllBlogAsync(CancellationToken ct)
    {
        await using var db = await _dbFactory.CreateDbContextAsync(ct);
        var repo = new BlogRepository(db);
        var blogs = await repo.AllBlogsAsync(ct);

        return blogs;
    }

    public async Task<IReadOnlyList<Post>> GetAllPostAsync(int blogId, CancellationToken ct)
    {
        await using var db = await _dbFactory.CreateDbContextAsync(ct);
        var repo = new PostRepository(db);
        var posts = await repo.GetPostsAsync(blogId, ct);

        return posts;
    }
}
