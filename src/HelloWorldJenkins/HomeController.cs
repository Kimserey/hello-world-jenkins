using Microsoft.AspNetCore.Mvc;

namespace HelloWorldJenkins
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello world";
        }
    }
}
