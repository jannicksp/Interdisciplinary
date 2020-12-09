using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interdisciplinary.Data;
using Interdisciplinary.Models;
using Interdisciplinary.Models.ViewModels;

namespace Interdisciplinary.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dataContext;
        private FridgeViewModel fridge = new FridgeViewModel();

        public HomeController(ApplicationDbContext dbContext)
        {
            dataContext = dbContext;
        }

        public IActionResult Index()
        {

            fridge.Ingredients = dataContext.Ingredients;
            return View(fridge);


        }

        public IActionResult AddIngredient()
        {
            //fridge.ChosenIngredient.add()
            return View(fridge);


        }
        public IActionResult Wheel()
        {
            return View();
        }
        public IActionResult Random()
        {
            return View();
        }


    }
}
