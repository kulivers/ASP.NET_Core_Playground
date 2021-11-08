using Microsoft.AspNetCore.Mvc;

namespace Playground.API.Controllers
{
    [ApiController]
    [Route("/api/test")]
    public class Test : ControllerBase
    {
        [HttpGet]
        public IActionResult Some()
        {
            return Ok("test");
        }
    }
}