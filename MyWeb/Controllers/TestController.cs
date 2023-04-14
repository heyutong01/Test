using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Message()
        {
            return Ok("完成");
        }

        [HttpGet]
        public IActionResult NewMessage()
        {
            return Ok("新的信息已完成");
        }
    }
}
