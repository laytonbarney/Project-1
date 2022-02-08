﻿using Microsoft.AspNetCore.Mvc;
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
            //THis push worked
            return View();
       }


        public IActionResult TaskForm()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
