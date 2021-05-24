using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApplicationMVC.Models;


namespace DemoApplicationMVC.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult BookDetails()
        {
            ViewData["Books"] = new BookModel() { BookId = 101, BookName = "JAVA", BookAuthor = "Deniss" }; //using Model
            return View();
        }
    }
}
