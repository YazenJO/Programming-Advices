using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirsrAPIController : ControllerBase
    {
        [HttpGet("MYName")]
        public string GetMyName(string Name)
        {
            return "My name is  " + Name;
        }
        [HttpGet("Sum")]
        public int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
