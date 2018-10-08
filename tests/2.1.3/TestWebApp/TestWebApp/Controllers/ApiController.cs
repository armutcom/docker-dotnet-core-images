using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return Ok(new {status = "success"});
        }
    }
}