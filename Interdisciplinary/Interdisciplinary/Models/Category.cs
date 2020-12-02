using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }



        public Category() { }
        public Category(int id, string name)
        {
            CategoryId = id;
            Name = name;
        }
    }
}
