using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MSIT141_Restful_Ajax_Homework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141_Restful_Ajax_Homework.Controllers
{
    public class HomeController : Controller
    {

        private readonly DemoContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DemoContext conetxt)
        {
            _logger = logger;
            _context = conetxt;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

        public IActionResult Homework2()
        {
            return View();
        }
        public IActionResult Homework3()
        {
            return View();
        }
        public IActionResult LoadAddress()
        {
            return Json(_context.Addresses);
        }
        public IActionResult LoginCheck(string name)
        {
            var exists = _context.Members.Any(m => m.Name == name);
            return Content(exists.ToString(), "text/plain");
        }

    }
}
