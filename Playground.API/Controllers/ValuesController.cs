using Microsoft.AspNetCore.Mvc;

namespace Playground.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var a = new[] { "value1", "value2" };
            return Ok(a) ;
        }
        [HttpGet("get2")]
        public IActionResult Get2()
        {
            return Ok("get2") ;
        }
    }
}