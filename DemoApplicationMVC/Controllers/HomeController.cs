using DemoApplicationMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

    

        public IActionResult Index()
        {
            ViewBag.LibraryItems = new List<string>() //using view Bag
            {
                "Student Details",
                "Book Details",
                "Assign Book",
                "Return Book"
            };

            List<string> Student = new List<string>();
            Student.Add("Hari");
            Student.Add("Priya");
            Student.Add("Manne");

            ViewData["Student"] = Student; //using View Data

            List<string> Students = new List<string>();
            Students.Add("Janu");
            Students.Add("Likith");
            Students.Add("Sindhu");

            TempData["Students"] = Students; //using Temp Data

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View("hh");
        }
        public IActionResult hh()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }


        public IActionResult About()
        {
            var obj = new { Id = 1, Name = "vamshi" };
            return View(obj);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
