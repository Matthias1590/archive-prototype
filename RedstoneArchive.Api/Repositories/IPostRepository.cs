using RedstoneArchive.Abstractions.Data.Models;

namespace RedstoneArchive.Api.Repositories;

public interface IPostRepository
{
    public Task<IEnumerable<Post>> GetPostsAsync();
    public Task<Post?> GetPostByIdAsync(int id);
    public Task<Post> AddPostAsync(Post post);

    public async Task<bool> PostExistsAsync(int id)
    {
        return await GetPostByIdAsync(id) is not null;
    }
}
