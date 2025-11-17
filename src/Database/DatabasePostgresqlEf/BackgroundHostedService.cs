using DatabaseCore.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatabasePostgresqlEf;

public class BackgroundHostedService : BackgroundService
{
    private readonly ILogger<BackgroundHostedService> _logger;
    private readonly BlogModel _model;

    public BackgroundHostedService(ILogger<BackgroundHostedService> logger, BlogModel model)
    {
        _logger = logger;
        _model = model;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var ct = stoppingToken;

        // Add records
        var current = await _model.GetOrAddBlogAsync(ct);
        await _model.AddPostAsync(current.BlogId, ct);

        // Get all records
        var blogs = await _model.GetAllBlogAsync(ct);
        foreach (var blog in blogs)
        {
            _logger.LogInformation($"BlogId {blog.BlogId}; Url {blog.Url}; Posts {blog.Posts.Count}");

            var posts = await _model.GetAllPostAsync(blog.BlogId, ct);
            foreach (var post in posts)
            {
                _logger.LogInformation($"  * PostId {post.PostId}; Title {post.Title};");
            }
        }
    }
}
