using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class CustomerDrink
    {
        public int CustomerDrinkId { get; set; }
        public int DrinkId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Drink Drink { get; set; }
    }
}
