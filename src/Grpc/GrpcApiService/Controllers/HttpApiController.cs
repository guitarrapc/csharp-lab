using Microsoft.AspNetCore.Mvc;

namespace GrpcApiService.Controllers;

[ApiController]
[Route("[controller]")]
public class HttpApiController : ControllerBase
{
    private readonly ILogger<HttpApiController> _logger;

    public HttpApiController(ILogger<HttpApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return "This is Http1 API.";
    }
}
