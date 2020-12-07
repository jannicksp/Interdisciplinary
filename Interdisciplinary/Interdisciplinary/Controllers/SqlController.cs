using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interdisciplinary.Data;
using Interdisciplinary.Models;
//using Microsoft.EntityFrameworkCore.Relational;
using Microsoft.EntityFrameworkCore;

namespace Interdisciplinary.Controllers
{
    public class SqlController : Controller
    {
        private ApplicationDbContext dataContext;
       private int[] ids = new int[] { 1, 3, 5, 7, 9 };
        private string string1;
        public SqlController(ApplicationDbContext dbContext)
        {
            dataContext = dbContext;
        }
        public IActionResult Index()
        {

            string1 = string.Join(",", ids);
            ViewBag.drinkids= dataContext.DrinkIngredients.FromSqlRaw($"SELECT * from DrinkIngredients where IngredientId in ({string1})").ToList();
                return View();
    }
        }
    }

