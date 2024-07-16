using Microsoft.AspNetCore.Mvc;

namespace TicTacToe_RESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet(Name = "GetTest")]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
