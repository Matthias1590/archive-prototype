using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace RedstoneArchive.Api.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class ControllerBase<TSelf> : ControllerBase
    where TSelf : ControllerBase<TSelf>
{
    protected readonly ILogger<TSelf> _logger;

    public ControllerBase(ILogger<TSelf> logger)
    {
        _logger = logger;
    }
}
