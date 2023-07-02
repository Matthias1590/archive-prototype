using Microsoft.EntityFrameworkCore;
using RedstoneArchive.Abstractions.Data.Models;

namespace RedstoneArchive.Abstractions.Data;

public class RedstoneArchiveContext : DbContext
{
    public RedstoneArchiveContext(DbContextOptions<RedstoneArchiveContext> options)
        : base(options)
    {
    }

    public DbSet<Post> Posts { get; } = default!;
    public DbSet<Schematic> Schematics { get; } = default!;
}
