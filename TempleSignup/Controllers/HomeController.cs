using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempleSignup.Models;

namespace TempleSignup.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private TempleContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, TempleContext x)
        {
            _logger = logger;
            _context = x;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {

            var times = _context.times.Where(x => x.Available == true).ToList();
            return View(times);
        }


        [HttpGet]
        public IActionResult Form(int id)
        {
           
            return View();
        }
    }
}
