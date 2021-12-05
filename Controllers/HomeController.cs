using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieSiteFinal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieSiteFinal.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */

        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var Movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
                return View(Movies);
        }



        public IActionResult About()
        {
            return View();
        }

    }
}
