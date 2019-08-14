using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojo.Models;

namespace dojo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("survey")]
        public IActionResult Survey(Dojo survey)
        {
            if(ModelState.IsValid){
                return RedirectToAction("Result",survey);
            }else{
                return View("Index",survey);
            }
        }

        public IActionResult Result(Dojo survey)
        {
            return View("Result",survey);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
