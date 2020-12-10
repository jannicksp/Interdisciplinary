using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Interdisciplinary.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }

        [Required, RegularExpression("^[a-zA-Z0-9]{1,99}$", ErrorMessage = "The name is required in correct format")]
        public string Name { get; set; }
        public string Amount { get; set; }

        //navigation property will create a foreign key
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        //public ICollection<Drink> Drinks { get; set; }

        public Ingredient() { }
        public Ingredient(int ingredientId, string name, Category category)
        {
            IngredientId = ingredientId;
            Name = name;
            Category = category;
        }
    }
}
