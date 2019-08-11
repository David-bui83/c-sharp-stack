using Microsoft.AspNetCore.Mvc;
using System;
namespace time.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            System.Console.WriteLine("######################");
            System.Console.WriteLine("The currrent time: " + CurrentTime);
            ViewBag.date = CurrentTime;
            return View("Index", ViewBag);
        }
        
    }
}