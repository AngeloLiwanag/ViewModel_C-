using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Here is a Message!";
            return View("Index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = { 1, 2, 3, 10, 43, 5 };
            return View("Number", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> names = new List<User>();
            User Angelo = new User("Angelo", "Liwanag");
            User Smithers = new User ("Smithers", "Nguyen");
            User Omi = new User ("Omi", "Oda");

            names.Add(Angelo);
            names.Add(Smithers);
            names.Add(Omi);

            return View("Users", names);
 
        }

        [HttpGet("user")]
        public new IActionResult User()
        {
            User name = new User("Angelo", "Liwanag");
            return View("User", name);
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
