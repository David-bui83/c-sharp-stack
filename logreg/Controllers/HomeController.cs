using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using logreg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace logreg.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email","Email is already taken");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user,user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id",userInDb.UserId);
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Index");

            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail","Invalid Email/Password");
                    return View("Index");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
                if(result==0)
                {
                    ModelState.AddModelError("LoginEmail","Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                    
                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id",userInDb.UserId);
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetString("id")==null)
            {
                return RedirectToAction("Index");
            }
            List<User> users = dbContext.Users.ToList();
            return View("Success",users);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            if(HttpContext.Session.GetString("id")==null)
            {
                return RedirectToAction("Index");
            }
            User user = dbContext.Users.SingleOrDefault(u => u.UserId == id);
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
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
