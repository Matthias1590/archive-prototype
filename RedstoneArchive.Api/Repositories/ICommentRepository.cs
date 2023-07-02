using RedstoneArchive.Abstractions.Data.Models;

namespace RedstoneArchive.Api.Repositories;

public interface ICommentRepository
{
    public Task<Comment?> AddCommentToPostByIdAsync(int postId, string comment);
    public Task<IEnumerable<Comment>?> GetCommentsByPostIdAsync(int postId);
}
