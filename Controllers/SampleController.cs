// Controllers/SampleController.cs
using DependencyInjectionExample.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly ILoggingService _loggingService;

    public SampleController(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    [HttpPost("log-action")]
    public IActionResult LogAction([FromBody] string action)
    {
        // Log the action
        _loggingService.LogInfo($"Action performed: {action}");

        return Ok("Action logged successfully.");
    }
}
