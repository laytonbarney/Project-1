using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        //This is added so we can add stuff to the database
        private TaskInfoContext DbContext { get; set; }

        //Same as above
        public HomeController(TaskInfoContext someName)
        {
            DbContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

       public IActionResult QuadrantView ()
       {
            
            return View();
       }


        //This is for Liberty's views populating the data so she can do drop downs in the form.
        
        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Categories = DbContext.Categories.ToList();
            return View();
        }

        //This is the post from the form
        [HttpPost]
        public IActionResult TaskForm(Tasks ta)
        {
            DbContext.Add(ta);
            DbContext.SaveChanges();

            return View("ConfirmationView", ta);
        }

    }
}
