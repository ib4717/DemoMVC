using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            String name = "Ishwar Baisla";
            ViewBag.Name = name;
            ViewData["Age"] = 23;
            TempData["Name"] = name;
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Name = TempData["Name"];
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}