using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quoting.Models;
// using DbConnection;

namespace quoting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("new")]
        public IActionResult New(string name, string quote)
        {
            string query =$"INSERT INTO users (name,quote) VALUES ('{name}','{quote}')";
            DbConnection.Execute(query);
            return RedirectToAction("Quotes");
        }

        [HttpGet("quote")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllUsers = DbConnection.Query("SELECT * FROM users");
            ViewBag.Users = AllUsers;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
