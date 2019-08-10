using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace portfolio.Controllers
{
    public class HelloController : Controller 
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        // [HttpGet]
        // [Route("projects")]
        [HttpGet("projects")]
        public string Projects(){
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contact(){
            return "This is my Contact!";
        }
    }
}