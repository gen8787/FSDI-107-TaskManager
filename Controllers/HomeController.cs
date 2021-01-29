using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
// v~~ S E T U P   V I E W S ~~v //
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


// v~~ M A I N   V I E W S ~~v //
    // I N D E X   P A G E
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    // P R I V A C Y   P A G E
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

    // A B O U T   P A G E
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

    // T A S K S   P A G E
        [HttpGet]
        public IActionResult Tasks()
        {
            return View();
        }

//<~~ E N D   O F   M A I N   V I E W S ~~> //
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
