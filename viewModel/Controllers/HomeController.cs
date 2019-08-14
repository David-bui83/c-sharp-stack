using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModel.Models;

namespace viewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum dignissim dapibus nisi, vitae laoreet nibh feugiat id. Praesent tristique cursus elit, id laoreet odio congue et. Sed eleifend erat id velit lacinia, quis consectetur lectus suscipit. Maecenas tempus eget urna ut tincidunt. Duis volutpat nulla nunc, et rhoncus enim pretium vitae. Pellentesque gravida ullamcorper enim in condimentum. Aenean dictum convallis ante, nec commodo orci volutpat a. Quisque et justo enim. Donec sollicitudin gravida lorem, sed feugiat massa iaculis ac. Fusce arcu nulla, congue non ligula eu, mattis sollicitudin erat. Phasellus nec leo varius, consequat sem eget, iaculis risus. Nullam dignissim justo vitae erat ultrices euismod. Cras quis mollis orci. Nullam id mollis velit. Maecenas mattis, lectus eget luctus laoreet, mauris nunc fringilla nisl, ac venenatis lacus velit eget felis. Ut ultrices non arcu et maximus.";
            return View("Index",str);
        }

        public IActionResult Numbers()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            return View("Numbers",numbers);
        }

        public IActionResult Users()
        {
            List<User> userList = new List<User>(){
                 new User{FirstName = "John", LastName="Doe"},
                 new User{FirstName = "Bob", LastName="Smith"},
                 new User{FirstName = "Ken", LastName="Brown"},
                 new User{FirstName = "Mike", LastName="Chen"},
                 new User{FirstName = "Lilly", LastName="Nguyen"}   
            };
            return View("Users",userList);
        }
        
        [HttpGet("SingleUser/{firstName}/{lastName}")]
        public IActionResult SingleUser(string firstName, string lastName)
        {   
            
            System.Console.WriteLine("#########################");
            // System.Console.WriteLine(firstName + lastName);
            User user = new User{
                FirstName = firstName,
                LastName = lastName
            };
            System.Console.WriteLine(user.FirstName);
            return View("SingleUser",user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
