using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models.ViewModels
{
    public class DrinksToIngredients
    {
        //public int DrinksToIngredientsId { get; set; }
        public int IngredientId { get; set; }
        public int DrinkId { get; set; }
        public string IngredientName { get; set; }
        public string DrinkName { get; set; }

        public string Amount { get; set; }


    }
}
