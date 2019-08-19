using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dachi dachi)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.GetString("name");
                HttpContext.Session.SetString("name",dachi.Name);
                HttpContext.Session.GetInt32("fullness");
                HttpContext.Session.SetInt32("fullness",50);
                HttpContext.Session.GetInt32("happiness");
                HttpContext.Session.SetInt32("happiness",20);
                HttpContext.Session.GetInt32("meals");
                HttpContext.Session.SetInt32("meals",3);
                HttpContext.Session.GetInt32("energy");
                HttpContext.Session.SetInt32("energy",50);
                HttpContext.Session.GetString("msg");
                HttpContext.Session.SetString("msg","Hello, Let's play.");

                dachi.Name = HttpContext.Session.GetString("name");
                dachi.Fullness=(int)HttpContext.Session.GetInt32("fullness");
                dachi.Happiness=(int)HttpContext.Session.GetInt32("happiness");
                dachi.Meals=(int)HttpContext.Session.GetInt32("meals");
                dachi.Energy=(int)HttpContext.Session.GetInt32("energy");
                dachi.Msg=HttpContext.Session.GetString("msg");
                return RedirectToAction("Dojodachi",dachi);
            }
            else{
                return View("Index");
            }
        }

        [HttpGet("dojodachi")]
        public IActionResult Dojodachi(Dachi dachi)
        {
            if(dachi.Name==null)
            {
                return View("Index");
            }

            if(HttpContext.Session.GetInt32("fullness") > 50 && HttpContext.Session.GetInt32("happiness")> 50 && HttpContext.Session.GetInt32("energy") > 50)
            {
                ViewBag.gameOver = true;
                ViewBag.msg = "Congradulation! You Win!";
            }
            else if(HttpContext.Session.GetInt32("fullness") < 0 || HttpContext.Session.GetInt32("happiness") < 0)
            {
                ViewBag.gameOver = true;
                ViewBag.msg = "Game Over! You Lose!";
            }
            else
            {
                ViewBag.gameOver = false;
            }
            return View("Dojodachi",dachi);
        }

        [HttpGet("feed")]
        public IActionResult Feed(Dachi dachi)
        {
            if(HttpContext.Session.GetInt32("meals")>0){
                Random ranMeal = new Random();
                if(ranMeal.Next(1,5)==1)
                {
                    int? meal = HttpContext.Session.GetInt32("meals") - 1;
                    HttpContext.Session.SetInt32("meals", (int)meal);
                    HttpContext.Session.SetString("msg",$"You feed {HttpContext.Session.GetString("name")} and it did not like the food.");
                }
                else
                {
                    int? meal = HttpContext.Session.GetInt32("meals") - 1;
                    HttpContext.Session.SetInt32("meals", (int)meal);
                    Random rand = new Random();
                    int newMeal = rand.Next(5,10);
                    int? full = HttpContext.Session.GetInt32("fullness") + newMeal;
                    HttpContext.Session.SetInt32("fullness", (int)full);

                    HttpContext.Session.SetString("msg",$"You feed {HttpContext.Session.GetString("name")} and it received fullness +{newMeal}.");
                }
            }

            dachi.Name = HttpContext.Session.GetString("name");
            dachi.Fullness=(int)HttpContext.Session.GetInt32("fullness");
            dachi.Happiness=(int)HttpContext.Session.GetInt32("happiness");
            dachi.Meals=(int)HttpContext.Session.GetInt32("meals");
            dachi.Energy=(int)HttpContext.Session.GetInt32("energy");
            dachi.Msg=HttpContext.Session.GetString("msg");
            return RedirectToAction("Dojodachi",dachi);
        }

        [HttpGet("play")]
        public IActionResult Play(Dachi dachi)
        {
            if(HttpContext.Session.GetInt32("energy")>0){
                int? energy = HttpContext.Session.GetInt32("energy")-5;
                HttpContext.Session.SetInt32("energy",(int)energy);
                Random rand = new Random();
                int ranhap = rand.Next(5,10);
                int? happy = HttpContext.Session.GetInt32("happiness") + ranhap;
                HttpContext.Session.SetInt32("happiness",(int)happy);

                HttpContext.Session.SetString("msg",$"You played with {HttpContext.Session.GetString("name")} and it received happiness +{ranhap} and energy -5.");
            }

            dachi.Name = HttpContext.Session.GetString("name");
            dachi.Fullness=(int)HttpContext.Session.GetInt32("fullness");
            dachi.Happiness=(int)HttpContext.Session.GetInt32("happiness");
            dachi.Meals=(int)HttpContext.Session.GetInt32("meals");
            dachi.Energy=(int)HttpContext.Session.GetInt32("energy");
            dachi.Msg=HttpContext.Session.GetString("msg");
            return RedirectToAction("Dojodachi",dachi);
        }

        [HttpGet("work")]
        public IActionResult Work(Dachi dachi)
        {
            if(HttpContext.Session.GetInt32("energy")>0)
            {
                int? energy = HttpContext.Session.GetInt32("energy") - 5;
                HttpContext.Session.SetInt32("energy",(int)energy);
                Random rand = new Random();
                int nMeal = rand.Next(1,3);
                int? meal = HttpContext.Session.GetInt32("meals") + nMeal;
                HttpContext.Session.SetInt32("meals",(int)meal);

                HttpContext.Session.SetString("msg",$"{HttpContext.Session.GetString("name")} worked and received +{nMeal} and energy -5.");
            }

            dachi.Name = HttpContext.Session.GetString("name");
            dachi.Fullness=(int)HttpContext.Session.GetInt32("fullness");
            dachi.Happiness=(int)HttpContext.Session.GetInt32("happiness");
            dachi.Meals=(int)HttpContext.Session.GetInt32("meals");
            dachi.Energy=(int)HttpContext.Session.GetInt32("energy");
            dachi.Msg=HttpContext.Session.GetString("msg");
            return RedirectToAction("Dojodachi", dachi);
        }
        [HttpGet("sleep")]
        public IActionResult Sleep(Dachi dachi)
        {
            int? energy = HttpContext.Session.GetInt32("energy") + 15;
            HttpContext.Session.SetInt32("energy", (int)energy);
            int? full = HttpContext.Session.GetInt32("fullness") - 5;
            HttpContext.Session.SetInt32("fullness",(int)full);
            int? happy = HttpContext.Session.GetInt32("happiness") - 5;
            HttpContext.Session.SetInt32("happiness",(int)happy);

            HttpContext.Session.SetString("msg",$"{HttpContext.Session.GetString("name")} slept and received energy +15, fullness -5, and happiness -5");

            dachi.Name = HttpContext.Session.GetString("name");
            dachi.Fullness=(int)HttpContext.Session.GetInt32("fullness");
            dachi.Happiness=(int)HttpContext.Session.GetInt32("happiness");
            dachi.Meals=(int)HttpContext.Session.GetInt32("meals");
            dachi.Energy=(int)HttpContext.Session.GetInt32("energy");
            dachi.Msg=HttpContext.Session.GetString("msg");
            return RedirectToAction("Dojodachi",dachi);
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
