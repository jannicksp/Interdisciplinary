using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interdisciplinary.Data;

namespace Interdisciplinary.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dataContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            dataContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.Drinks = dataContext.Drinks;
            return View();
        }
        public IActionResult Wheel()
        {
            return View();
        }
        public IActionResult Fridge()
        {
            return View();
        }

    }
}
