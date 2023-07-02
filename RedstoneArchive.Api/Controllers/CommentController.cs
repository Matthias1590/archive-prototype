using Microsoft.AspNetCore.Mvc;
using RedstoneArchive.Api.Repositories;

namespace RedstoneArchive.Api.Controllers;

public class CommentController : ControllerBase<CommentController>
{
    private readonly ICommentRepository _commentRepository;

    public CommentController(ILogger<CommentController> logger, ICommentRepository commentRepository)
        : base(logger)
    {
        _commentRepository = commentRepository;
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetCommentsByPostIdAsync(int id)
    {
        var comments = await _commentRepository.GetCommentsByPostIdAsync(id);
        if (comments is null)
        {
            return NotFound();
        }

        return Ok(comments);
    }

    [HttpPost]
    public async Task<IActionResult> AddCommentToPostByIdAsync(int postId, string content)
    {
        var comment = await _commentRepository.AddCommentToPostByIdAsync(postId, content);
        if (comment is null)
        {
            return NotFound();
        }

        return Ok(comment);
    }
}
