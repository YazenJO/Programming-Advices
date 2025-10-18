using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstController : ControllerBase
    {
        // GET api/myfirst
        [HttpGet]
        public string  Get()
        {
            return "Hello from MyFirstController!";
        }

        
    }
}
