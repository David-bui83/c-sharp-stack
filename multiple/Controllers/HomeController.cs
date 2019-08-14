using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using multiple.Models;

namespace multiple.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("registration")]
        public IActionResult Registration(IndexModel reg)
        {   
            // System.Console.WriteLine("#####################");
            // System.Console.WriteLine(reg.NewReg.FirstName);
            Registration newReg = reg.NewReg;

            if(ModelState.IsValid)
            {
                return RedirectToAction("Privacy");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult LogIn(IndexModel log)
        {
            Login newLog = log.NewLog;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Privacy");
            }
            else
            {
                return View("Index");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
