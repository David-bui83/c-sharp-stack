using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crudelicious.Models;

namespace crudelicious.Controllers
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
            List<Recipe> recipes = dbContext.Recipes.OrderByDescending(r => r.RecipeId).ToList();
            ViewBag.recipes = recipes;
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {   
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Recipe recipe)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(recipe);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet("view/{id}")]
        public IActionResult ViewOne(int id)
        {
            Recipe recipe = dbContext.Recipes.FirstOrDefault(r => r.RecipeId==id);
            ViewBag.recipe=recipe;
            return View("ViewOne");
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Recipe recipe = dbContext.Recipes.FirstOrDefault(r => r.RecipeId==id);
            
            return View("Edit",recipe);
        }

        [HttpPost("update/{id}")]
        public IActionResult UpdateOne(int id, Recipe updatedRecipe)
        {
            if(ModelState.IsValid)
            {
                Recipe recipe = dbContext.Recipes.FirstOrDefault(r => r.RecipeId==id);
                recipe.Name = updatedRecipe.Name;
                recipe.Chef = updatedRecipe.Chef;
                recipe.Tastiness = updatedRecipe.Tastiness;
                recipe.Calories = updatedRecipe.Calories;
                recipe.Description = updatedRecipe.Description;
                recipe.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }
            
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteOne(int id)
        {
            Recipe recipe = dbContext.Recipes.SingleOrDefault(r => r.RecipeId == id);
            dbContext.Recipes.Remove(recipe);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
