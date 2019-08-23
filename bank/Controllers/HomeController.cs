using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace bank.Controllers
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

        [HttpPost("registration")]
        public IActionResult Registration(Account account)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Accounts.Any(a => a.Email == account.Email))
                {
                    ModelState.AddModelError("Email", "Email is already taken");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<Account> hasher = new PasswordHasher<Account>();
                    account.Password = hasher.HashPassword(account,account.Password);
                    dbContext.Add(account);
                    dbContext.SaveChanges();

                    var acc = dbContext.Accounts.FirstOrDefault(a => a.Email == account.Email);
                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id",acc.AccountId);
                    return RedirectToAction("Success");
                }
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult LoginCheck(Login login)
        {
            if(ModelState.IsValid)
            {
                var acc = dbContext.Accounts.FirstOrDefault(a => a.Email == login.LoginEmail);
                if(acc == null)
                {
                    ModelState.AddModelError("LoginEmail","Invalid Email/Password");
                    return View("Login");
                }

                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(login, acc.Password,login.LoginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail","Invalid Email/Password");
                    return View("Login");
                }
                else
                {
                    var accId = acc.AccountId;
                return RedirectToAction("Success", new {id=accId});
                }
            }
            return View("Login");
        }

        [HttpGet("success/{id}")]
        public IActionResult Success(int id)
        {
            HttpContext.Session.SetInt32("id",id);
            if(HttpContext.Session.GetInt32("id")== null)
            {
                return View("Index");
            }

            var acc = dbContext.Accounts.Include(c => c.Transactions).FirstOrDefault(a => a.AccountId == id);
            ;
            return View("Success",acc);
        }

        [HttpPost("transaction")]
        public IActionResult Transaction(Transaction trans)
        {
            var acc = dbContext.Accounts.Include(c => c.Transactions).FirstOrDefault(a => a.AccountId == HttpContext.Session.GetInt32("id"));
            if(ModelState.IsValid)
            {
                var pass = acc.Balance + (decimal)trans.Amount;
                if( pass < 0)
                {
                    return View("Success",acc);
                }
                else
                {
                    acc.Balance += (decimal)trans.Amount;
                    // trans.AccountId = acc.AccountId;
                    dbContext.Transactions.Add(trans);
                    dbContext.SaveChanges();
                    return RedirectToAction("Success",new {id=acc.AccountId});
                }

            }
            
            return View("Success",acc);
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
