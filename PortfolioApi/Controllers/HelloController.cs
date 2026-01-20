using Microsoft.AspNetCore.Mvc;

namespace PortfolioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                message = "Hello Portfolio API!",
                createdAt = DateTime.Now
            });
        }
    }
}