using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class DrinkIngredient
    {
        public int DrinkIngredientId { get; set; }
        public Drink Drink { get; set; }
        public int DrinkId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }
        public string Amount { get; set; }
    }
}
