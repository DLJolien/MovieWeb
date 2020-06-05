﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieWeb.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Welcome(string name = "Vreemdeling", int numberOfTimes = 1)
        {
            ViewData["Name"] = name;
            ViewData["NumberOfTimes"] = numberOfTimes;
            return View();
        }
    }
}
