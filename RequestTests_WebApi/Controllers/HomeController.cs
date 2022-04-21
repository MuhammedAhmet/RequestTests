using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RequestTests_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("Maraba")]   // api/Home/Maraba
        public IActionResult Maraba()
        {
            return Ok("API HOME MARABA");
        }

        [HttpGet]
        [Route("/Maraba")]  // localhost/Maraba
        public IActionResult Maraba2()
        {
            return Ok("INDEX");
        }

        [HttpGet]
        [Route("/")]  // localhost/Maraba
        public IActionResult Index()
        {
            return Ok("INDEX");
        }

    }
}
