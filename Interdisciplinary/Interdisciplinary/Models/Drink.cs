using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public bool IsCreated { get; set; } = false;

        //public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public ICollection<Ingredient> Ingredients { get; set; } 

        //navigation property will create a foreign key
      public Customer Customer { get; set; }
      public int CustomerId { get; set; }

        public Drink() { }
        public Drink(int drinkId, string name, ICollection<Ingredient> ingredients)
        {
            DrinkId = drinkId;
            Name = name;
            Ingredients = ingredients;
        }

    }
}
