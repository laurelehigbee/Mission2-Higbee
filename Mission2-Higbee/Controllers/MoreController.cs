using Microsoft.AspNetCore.Mvc;
using Mission2_Higbee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2_Higbee.Controllers
{
    public class MoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculator model)
        {
            return View();
        }
    }
}
