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
    public async Task<IActionResult> GetAsync()
    {
        _logger.LogInformation("Getting posts");

        return Ok(await _postRepository.GetPostsAsync());
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetPostByIdAsync(int id)
    {
        _logger.LogInformation("Getting post by id {id}", id);

        var post = await _postRepository.GetPostByIdAsync(id);
        if (post is null)
        {
            return NotFound();
        }

        return Ok(post);
    }

    [HttpPost]
    public async Task<IActionResult> AddPostAsync(Post post)
    {
        _logger.LogInformation("Creating post");

        return Ok(await _postRepository.AddPostAsync(post));
    }
}
