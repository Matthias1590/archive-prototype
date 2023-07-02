using Microsoft.AspNetCore.Mvc;
using RedstoneArchive.Abstractions.Data.Models;
using RedstoneArchive.Api.Repositories;

namespace RedstoneArchive.Api.Controllers;

public class PostController : ControllerBase<PostController>
{
    private readonly IPostRepository _postRepository;

    public PostController(ILogger<PostController> logger, IPostRepository postRepository)
        : base(logger)
    {
        _postRepository = postRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Post>> GetAsync()
    {
        _logger.LogInformation("Getting posts");

        return await _postRepository.GetPostsAsync();
    }

    [HttpGet("/{id}")]
    public async Task<Post?> GetPostByIdAsync(int id)
    {
        _logger.LogInformation("Getting post by id {id}", id);

        return await _postRepository.GetPostByIdAsync(id);
    }

    [HttpPost]
    public async Task AddPostAsync(Post post)
    {
        _logger.LogInformation("Creating post");

        await _postRepository.AddPostAsync(post);
    }
}
