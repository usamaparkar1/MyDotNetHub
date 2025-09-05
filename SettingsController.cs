using Microsoft.AspNetCore.Mvc;
using MyDotNetHub.Models;
using MyDotNetHub.Services;

// Usama 8July2025: I will rename this namespace to something more meaningfull later on.
namespace MyDotNetHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingsController : ControllerBase
    {
        public SettingsController()
        {
        }

        [HttpGet("GetSettings")]
        public ActionResult<AppSettings> GetSettings()
        {
            string appVersionNumber = Request.Headers["X-App-Version"].ToString();

            // Validate or log version
            if (string.IsNullOrWhiteSpace(appVersionNumber))
            {
                return BadRequest("App version is required.");
            }

            SettingsService settingsService = new SettingsService();
            return Ok(settingsService.GetSettingsByAppVersionNumber(appVersionNumber));
        }
    }
}