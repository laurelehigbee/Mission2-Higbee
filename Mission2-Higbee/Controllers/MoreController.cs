using Microsoft.AspNetCore.Mvc;
using Mission3_Higbee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace Mission3_Higbee.Controllers
{
    public class MoreController : Controller
    {
        public IActionResult Index()
        {
            return View(); //what to return with the index page
        }
        [HttpGet] //get method
        public IActionResult GradeCalculator()
        {
            return View(); //what to return after getting
        }
        [HttpPost] //post method
        public IActionResult GradeCalculator(GradeCalculator model)//tells it to use the gradecalculator  model
        {
            return View(); //what to return after posting
        }
    }
}
