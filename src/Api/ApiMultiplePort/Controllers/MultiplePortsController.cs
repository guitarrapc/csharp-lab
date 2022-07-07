using ApiMultiplePort.Attirbutes;
using Microsoft.AspNetCore.Mvc;

namespace ApiMultiplePort.Controllers;

[PortsActionConstraint(new[] { 5095, 5096 })]
[ApiController]
[Route("[controller]")]
public class MultiplePortsController : ControllerBase
{
    private readonly ILogger<AnotherPortController> _logger;

    public MultiplePortsController(ILogger<AnotherPortController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBar")]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5).ToArray();
    }
}
