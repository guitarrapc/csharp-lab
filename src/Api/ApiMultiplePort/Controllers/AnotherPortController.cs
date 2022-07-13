using ApiMultiplePort.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace ApiMultiplePort.Controllers;

[PortActionConstraint(5095)]
[ApiController]
[Route("[controller]")]
public class AnotherPortController : ControllerBase
{
    private readonly ILogger<AnotherPortController> _logger;

    public AnotherPortController(ILogger<AnotherPortController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFoo")]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5).ToArray();
    }
}
