using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using woods.Models;
using woods.Factory;

namespace woods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory TrailFactory;
        public HomeController()
        {
            TrailFactory = new TrailFactory();
        }
        public IActionResult Index()
        {
            ViewBag.trails = TrailFactory.FindAll();
            return View();
        }

        [HttpGet("trail/{id}")]
        public IActionResult Trail(int id)
        {
            ViewBag.trail = TrailFactory.FindByID(id);
            return View("Trail");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("create")]
        public IActionResult Create(Trail trail)
        {
            
            if(ModelState.IsValid)
            {
                TrailFactory.Add(trail);
                return RedirectToAction("Index");
            }
            else{
                return View("New");
            }
        }

        public IActionResult Trail()
        {
            return View("Trail");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
