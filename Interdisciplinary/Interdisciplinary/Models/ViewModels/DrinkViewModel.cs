using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interdisciplinary.Models;

namespace Interdisciplinary.Models.ViewModels
{
    public class DrinkViewModel
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }

        public List<DrinksToIngredients> Ingredients { get; set; }
    }
}
