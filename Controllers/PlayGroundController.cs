using Microsoft.AspNetCore.Mvc;

namespace MyNamespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayGroundController : ControllerBase
    {
        private readonly ILogger<PlayGroundController> _logger;

        public PlayGroundController(ILogger<PlayGroundController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Log to Application Insights
            _logger.LogInformation("PlayGroundController GET endpoint called at {Time}", DateTime.UtcNow);

            return Ok("Success");
        }
    }
}