using Microsoft.AspNetCore.Mvc;
using System;
namespace forms.Controllers
{
    public class FormsController : Controller 
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("submit")]
        public IActionResult Submit(string name, string location, string language, string comment)
        {
           
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            
            

            return View("Result");
        }

        // [HttpGet("{result}")]
        // public IActionResult Result(string name, string location, string language, string comment)
        // {
            
        //     System.Console.WriteLine("##########################");
        //     System.Console.WriteLine(name);
        //     //  ViewBag.user = new {
        //     //     Name=name,
        //     //     location=location,
        //     //     language=language,
        //     //     comment=comment
        //     // };
            
           
        //     return View("Result");
        // }
    }
}