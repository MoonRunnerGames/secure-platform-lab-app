using Microsoft.AspNetCore.Mvc;

namespace SecurePlatformLab.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "Healthy",
            service = "SecurePlatformLab.Api",
            timestampUtc = DateTime.UtcNow
        });
    }
}