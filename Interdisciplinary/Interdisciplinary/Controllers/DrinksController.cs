using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interdisciplinary.Models.ViewModels;

namespace Interdisciplinary.Controllers
{
    public class DrinksController : Controller
    {
        [HttpPost]
        public IActionResult Index(IEnumerable<string> selected)
        {
            
            return View(selected);
        }

      
    }
}
