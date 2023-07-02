using Microsoft.EntityFrameworkCore;
using RedstoneArchive.Abstractions.Data;
using RedstoneArchive.Abstractions.Data.Models;

namespace RedstoneArchive.Api.Repositories;

public class PostRepository : RepositoryBase<PostRepository>, IPostRepository
{
    public PostRepository(ILogger<PostRepository> logger, RedstoneArchiveContext context)
        : base(logger, context)
    {
    }

    public async Task AddPostAsync(Post post)
    {
        await _context.Posts.AddAsync(post);

        await _context.SaveChangesAsync();
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        return await _context.Posts.FindAsync(id);
    }

    public async Task<IEnumerable<Post>> GetPostsAsync()
    {
        return await _context.Posts.ToListAsync();
    }
}
