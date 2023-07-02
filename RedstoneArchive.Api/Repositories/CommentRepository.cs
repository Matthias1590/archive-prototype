using Microsoft.EntityFrameworkCore;
using RedstoneArchive.Abstractions.Data;
using RedstoneArchive.Abstractions.Data.Models;
using RedstoneArchive.Api.Helpers;

namespace RedstoneArchive.Api.Repositories;

public class CommentRepository : RepositoryBase<CommentRepository>, ICommentRepository
{
    private readonly IPostRepository _postRepository;

    public CommentRepository(ILogger<CommentRepository> logger, RedstoneArchiveContext context, IPostRepository postRepository)
        : base(logger, context)
    {
        _postRepository = postRepository;
    }

    public async Task<Comment?> AddCommentToPostByIdAsync(int postId, string content)
    {
        var post = await _context.Posts.FindAsync(postId);
        if (post is null)
        {
            return null;
        }

        var comment = new Comment
        {
            PostedAt = DateTime.Now,
            Content = content,
            Post = post
        };

        await _context.Comments.AddAsync(comment);

        await _context.SaveChangesAsync();

        return comment;
    }

    public async Task<IEnumerable<Comment>?> GetCommentsByPostIdAsync(int postId)
    {
        if (!await _postRepository.PostExistsAsync(postId))
        {
            return null;
        }

        return await _context.Comments
            .Where(c => c.Post.PostId == postId)
            .ToListAsync();
    }
}
