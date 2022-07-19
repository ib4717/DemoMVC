using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie(1, "RRR", 2022, 5);
            return View(movie);
        }

        public IActionResult List()
        {
            List<Movie> movies = GetMovies();
            return View(movies) ;
        }

        public IActionResult Find()
        {
            return View();
        }

        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie(1, "RRR", 2022, 4),
                new Movie(2, "Avatar", 2009, 5),
                new Movie(3, "KGF", 2022, 4),
                new Movie(4, "Avengers Endgame", 2019, 5),
                new Movie(5, "Spider Man No Way Home", 2022, 5),
                new Movie(6, "War", 2021, 3)
            };

            return movies;
        }

        public IActionResult SearchMovie(int movieid)
        {
            List<Movie> movies = GetMovies();
            var data = movies.Where(m => m.Id == movieid).FirstOrDefault();
            return View("Index", data);
        }

        [HttpGet]
        public IActionResult FindByYear()
        {
            DateTime now = DateTime.Today;
            List<int> yearList = new List<int>();
            for (int y = 2009; y <= Convert.ToInt32(now.ToString("yyyy")); y++)
            {
                yearList.Add(y);
            }
            ViewBag.year = new SelectList(yearList);
            return View();
        }

        [HttpPost]
        public IActionResult FindByYear(int year)
        {
            DateTime now = DateTime.Today;
            List<int> yearList = new List<int>();
            for (int y = 2009; y <= Convert.ToInt32(now.ToString("yyyy")); y++)
            {
                yearList.Add(y);
            }
            ViewBag.year = new SelectList(yearList);

            List<Movie> movies = GetMovies();
            var data = movies.Where(m => m.Year == year);
            ViewBag.Movies = data;
            return View("FindByYear", data);
        }
    }
}