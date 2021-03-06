﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interdisciplinary.Models;
using Interdisciplinary.Models.ViewModels;
using Interdisciplinary.Data;
using Microsoft.EntityFrameworkCore;
using Interdisciplinary.Infrastructure;

namespace Interdisciplinary.Controllers
{
    public class DrinksController : Controller
    {
        private ApplicationDbContext dataContext;
        private DrinksListViewModel drinks = new DrinksListViewModel();
        private List<DrinkIngredient> ids;
        public DrinksController(ApplicationDbContext dbContext)
        {
            dataContext = dbContext;
        }


        public IActionResult Index() {
            DrinksListViewModel DrinksList = GetList();
            if (DrinksList == null)
            {
                DrinksList = new DrinksListViewModel();
                DrinksList.Drinks = new List<DrinkViewModel>();
            }
            return View(DrinksList);}

        [HttpPost]
        public IActionResult Index(IEnumerable<string> selected)
        {

            drinks.Drinks = new List<DrinkViewModel>();
            string ingredientIds = string.Join(",", selected);
            ids = dataContext.DrinkIngredients.FromSqlRaw($"SELECT * from DrinkIngredients where IngredientId in ({ingredientIds})").ToList();

            foreach (DrinkIngredient drinkid in ids) {
                int id = drinkid.DrinkId;
                List<DrinksToIngredients> ingredients = dataContext.DrinksToIngredients.FromSqlRaw<DrinksToIngredients>($"SELECT * from DrinksToIngredientsView where DrinkId = {id}").ToList();
                DrinkViewModel drink = new DrinkViewModel();
                drink.DrinkId = id;
                
                drink.Ingredients = new List<DrinksToIngredients>();
                foreach(DrinksToIngredients e in ingredients)
                {
                    drink.Ingredients.Add(e);
                    drink.DrinkName = e.DrinkName;
                }
                drinks.Drinks.Add(drink);
                    }


            SaveList(drinks);


            return View(drinks);


        }


        private DrinksListViewModel GetList() { 
            DrinksListViewModel DrinksList = HttpContext.Session.GetJson<DrinksListViewModel>("DrinksList"); 
            return DrinksList; 
        }

        private void SaveList(DrinksListViewModel DrinksList) 
        { 
            HttpContext.Session.SetJson("DrinksList", DrinksList); 
        }








    }
}
