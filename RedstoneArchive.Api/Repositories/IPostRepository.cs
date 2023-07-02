using RedstoneArchive.Abstractions.Data.Models;

namespace RedstoneArchive.Api.Repositories;

public interface IPostRepository
{
    public Task<IEnumerable<Post>> GetPostsAsync();
    public Task<Post?> GetPostByIdAsync(int id);
    public Task AddPostAsync(Post post);
}
