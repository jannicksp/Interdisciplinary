using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Interdisciplinary.Models;

namespace Interdisciplinary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDrink> CustomerDrinks { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkIngredient> DrinkIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }




    }
}
