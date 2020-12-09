using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models.ViewModels
{
    public class FridgeViewModel
    {

        public IEnumerable<Ingredient> Ingredients { get; set; }
        public ICollection<Ingredient> ChosenIngredients { get; set; }
    }
}
