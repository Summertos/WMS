﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMS.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
