using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public HealthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Status = "Healthy",
                ApplicationName = _configuration["ApplicationSettings:ApplicationName"],
                SupportEmail = _configuration["ApplicationSettings:SupportEmail"],
                StudentPortalBaseUrl = _configuration["ExternalServices:StudentPortalBaseUrl"]
            });
        }
    }
}