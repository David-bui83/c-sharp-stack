using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using passcode.Models;
using Microsoft.AspNetCore.Http;

namespace passcode.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("score")==null)
            {
                HttpContext.Session.SetInt32("score",0);
            }
            // else
            // {
            //     int? sessionScore = HttpContext.Session.GetInt32("score");
            //     sessionScore++;
            //     HttpContext.Session.SetInt32("score",(int)sessionScore);
            // }
            ViewBag.score=HttpContext.Session.GetInt32("score");
            return View();
        }
        [HttpGet("click")]
        public IActionResult Click()
        {
            if(HttpContext.Session.GetInt32("score")==null)
            {
                HttpContext.Session.SetInt32("score",1);
            }
            else
            {
                int? sessionScore = HttpContext.Session.GetInt32("score");
                sessionScore++;
                HttpContext.Session.SetInt32("score",(int)sessionScore);
            }
            ViewBag.score=HttpContext.Session.GetInt32("score");

            Random rand = new Random();
            string[] str = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
            string newPass="";
            for(int i  = 1; i<=14; i++){
                newPass += str[rand.Next(0,str.Length)];
            }

            return View("Index",newPass);
        }
        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
