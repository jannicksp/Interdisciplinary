using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Interdisciplinary.Models
{
    public class DrinkIngredient
    {
        public int DrinkIngredientId { get; set; }
        public Drink Drink { get; set; }
        public int DrinkId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        [Required, RegularExpression("^[a-zA-Z0-9]{1,20}$", ErrorMessage = "The amount is required in correct format")]
        public string Amount { get; set; }
    }
}
