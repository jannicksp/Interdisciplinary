using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Interdisciplinary.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }

        [Required, RegularExpression("^[a-zA-Z0-9]{1,99}$", ErrorMessage="The name is required in correct format")]
        public string Name { get; set; }
        public bool IsCreated { get; set; } = false;

        //public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        //navigation property
        //public virtual ICollection<Ingredient> Ingredients { get; set; } 

        //navigation property will create a foreign key
    

        public Drink() { }
        public Drink(int drinkId, string name, ICollection<Ingredient> ingredients)
        {
            DrinkId = drinkId;
            Name = name;
            //Ingredients = ingredients;
        }

    }
}
