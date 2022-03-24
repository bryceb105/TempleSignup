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

        private TempleContext _context { get; set; }

        public HomeController(TempleContext x)
        {
            _context = x;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp(int pageNum = 1)
        {
            int pageSize = 13;


            var times = _context.responses.OrderBy(x => x.id).Skip((pageNum-1) * pageSize).ToList();
            return View(times);
        }


        [HttpGet]
        public IActionResult Form(int id)
        {
            var slot = _context.responses.Single(x => x.id == id);

            return View(slot);
        }

        [HttpPost]
        public IActionResult Form(TempleModel tm)
        {

                _context.Update(tm);
                _context.SaveChanges();
                return RedirectToAction("SignUp");
        }

        public IActionResult Appointments ()
        {
            return View();
        }
    }
}
