﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICDETool.Controllers
{
    public class TemplateController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Concept()
        {
            return View();
        }

        public IActionResult ConceptPlanning()
        {
            return View();
        }

        public IActionResult Template()
        {
            return View();
        }

        public IActionResult TemplatePlanning()
        {
            return View();
        }
    }
}

