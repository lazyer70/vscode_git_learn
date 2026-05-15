using Microsoft.AspNetCore.Mvc;

namespace learn_git.Controllers;

[ApiController]
[Route("api")]
public class SystemController : ControllerBase
{
    [HttpGet("time")]
    public IActionResult GetCurrentTime()
    {
        var now = DateTimeOffset.Now;
        return Ok(new
        {
            now = now.ToString("O"),
            unixTimeSeconds = now.ToUnixTimeSeconds()
        });
    }

    [HttpGet("healthy")]
    public IActionResult GetStatus()
    {
        return Ok("healthy");
    }

    [HttpGet("version")]
    public IActionResult GetVersion()
    {
        return Ok(new { version = "V0.3" });
    }
}