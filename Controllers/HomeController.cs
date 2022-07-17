using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
            => Ok($"Hello world {DateTime.UtcNow} ! ");   
    }
}