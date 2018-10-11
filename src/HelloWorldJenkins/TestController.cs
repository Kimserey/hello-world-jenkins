using Microsoft.AspNetCore.Mvc;

namespace HelloWorldJenkins
{
    [Route("/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello world from controller";
        }
    }
}
