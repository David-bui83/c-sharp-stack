using Microsoft.AspNetCore.Mvc;

namespace razor.Controllers
{
    public class RazorController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}