using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chef.Models;
using Microsoft.EntityFrameworkCore;

namespace chef.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            List<Chef> chefList = dbContext.Chefs.Include(c => c.CreateDishes).ToList();
            foreach(var chef in chefList)
            {
                System.Console.WriteLine(chef.FirstName);
            }
            return View("Index",chefList);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            
            return View("New");
        }

        [HttpPost("add/chef")]
        public IActionResult AddChef(Chef chef)
        {
            if(ModelState.IsValid) 
            {
                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> dishList = dbContext.Dishes.Include(c => c.Creator).ToList();
            
            return View("Dishes",dishList);
        }

        [HttpGet("dishes/new")]
        public IActionResult AddDish()
        {
            List<Chef> chefList = dbContext.Chefs.ToList();
            System.Console.WriteLine("##################");
            foreach(var chef in chefList)
            {
                System.Console.WriteLine(chef.ChefId);
            }
            ViewBag.chefs = chefList;
            return View("Add");
        }

        [HttpPost("create/dish")]
        public IActionResult CreateDish(Dish dish)
        {
            Dish newdish = dish;
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                List<Chef> chefList = dbContext.Chefs.ToList();
                ViewBag.chefs = chefList;
                return View("Add");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
