using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyNamespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayGroundController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Success");
        }
    }
}