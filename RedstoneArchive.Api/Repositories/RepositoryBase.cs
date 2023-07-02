using RedstoneArchive.Abstractions.Data;

namespace RedstoneArchive.Api.Repositories;

public abstract class RepositoryBase<TSelf>
    where TSelf : RepositoryBase<TSelf>
{
    protected readonly ILogger<TSelf> _logger;
    protected readonly RedstoneArchiveContext _context;

    protected RepositoryBase(ILogger<TSelf> logger, RedstoneArchiveContext context)
    {
        _logger = logger;
        _context = context;
    }
}
