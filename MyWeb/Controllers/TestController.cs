using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Message")]
        public IActionResult Message1()
        {
            return Ok("请求01完成");
        }


        [HttpGet("Message")]
        public IActionResult Message2()
        {
            return Ok("请求02完成");
        }
    }
}
