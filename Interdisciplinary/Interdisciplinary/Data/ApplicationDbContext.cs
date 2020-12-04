using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Interdisciplinary.Models;
using System.Linq;

namespace Interdisciplinary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DrinkIngredient> DrinkIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //if we wanted to override default naming behaviour, and name table "Customer" instead of "Customers" for example
            //modelBuilder.Entity<Customer>().ToTable("Customer");
            //modelBuilder.Entity<Drink>().ToTable("Drink");
            //modelBuilder.Entity<Category>().ToTable("Category");
            //modelBuilder.Entity<DrinkIngredient>().ToTable("DrinkIngredient");
            //modelBuilder.Entity<Ingredient>().ToTable("Ingredient");

            modelBuilder.Entity<Category>().HasData(
                         new Category
                         {
                             CategoryId = 1,
                             Name = "Alkohol"
                             
                         },

                         new Category
                         {
                             CategoryId = 2,
                             Name = "Mixer"
                         },

                          new Category
                          {
                              CategoryId = 3,
                              Name = "Garnish"
                          }

                         );

            modelBuilder.Entity<Ingredient>().HasData(
                    new Ingredient
                    {
                        IngredientId = 1,
                        Name = "Gin",
                        CategoryId = 1
                    },
                     new Ingredient
                     {
                         IngredientId = 2,
                         Name = "Dark Rum",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 3,
                         Name = "Light Rum",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 4,
                         Name = "Vodka",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 5,
                         Name = "Tequila",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 6,
                         Name = "Cointreau",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 7,
                         Name = "Tonic",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 8,
                         Name = "Orange Juice",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 9,
                         Name = "Cola",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 10,
                         Name = "Sprite",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 11,
                         Name = "Lime Juice",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 12,
                         Name = "Lemon Juice",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 13,
                         Name = "Grenadine",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 14,
                         Name = "Cranberry Juice",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 15,
                         Name = "Sugar Syrup",
                         CategoryId = 2
                     },
                     new Ingredient
                     {
                         IngredientId = 16,
                         Name = "Dry Vermouth",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 17,
                         Name = "Whiskey",
                         CategoryId = 1
                     },
                     new Ingredient
                     {
                         IngredientId = 18,
                         Name = "Ice Cubes",
                         CategoryId = 3
                     },
                     new Ingredient
                     {
                         IngredientId = 19,
                         Name = "Crushed Ice",
                         CategoryId = 3
                     },
                     new Ingredient
                     {
                         IngredientId = 20,
                         Name = "Lime slices",
                         CategoryId = 3
                     },
                     new Ingredient
                     {
                         IngredientId = 21,
                         Name = "Salt",
                         CategoryId = 3
                     },
                     new Ingredient
                     {
                         IngredientId = 22,
                         Name = "Olive",
                         CategoryId = 3
                     },
                     new Ingredient
                     {
                         IngredientId = 23,
                         Name = "Mint Leaves",
                         CategoryId = 3
                     },
                     new Ingredient
                     {
                         IngredientId = 24,
                         Name = "Sugar",
                         CategoryId = 3
                     }


                    );

            modelBuilder.Entity<Drink>().HasData(
                    new Drink { DrinkId = 1, Name = "Vodka Juice"},
                    new Drink { DrinkId = 2, Name = "Rum and Coke" },
                    new Drink { DrinkId = 3, Name = "Gin and Tonic" },
                    new Drink { DrinkId = 4, Name = "Margarita" },
                    new Drink { DrinkId = 5, Name = "Cosmopolitan" },
                    new Drink { DrinkId = 6, Name = "Gin Martini" },
                    new Drink { DrinkId = 7, Name = "Vodka Martini" },
                    new Drink { DrinkId = 8, Name = "Mojito" },
                    new Drink { DrinkId = 9, Name = "Whiskey Sour" },
                    new Drink { DrinkId = 10, Name = "Daiquiri" },
                    new Drink { DrinkId = 11, Name = "Tequila Sunrise" }

                    );

            modelBuilder.Entity<DrinkIngredient>().HasData(
                  new DrinkIngredient { DrinkIngredientId = 1, DrinkId = 1, IngredientId = 4, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 2, DrinkId = 1, IngredientId = 8, Amount = "6cl" },
                  new DrinkIngredient { DrinkIngredientId = 3, DrinkId = 1, IngredientId = 18, Amount = "" },
                  new DrinkIngredient { DrinkIngredientId = 4, DrinkId = 2, IngredientId = 2, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 5, DrinkId = 2, IngredientId = 9, Amount = "6cl" },
                  new DrinkIngredient { DrinkIngredientId = 6, DrinkId = 2, IngredientId = 18, Amount = "" },
                  new DrinkIngredient { DrinkIngredientId = 7, DrinkId = 3, IngredientId = 1, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 8, DrinkId = 3, IngredientId = 7, Amount = "6cl" },
                  new DrinkIngredient { DrinkIngredientId = 9, DrinkId = 3, IngredientId = 18, Amount = "" },
                  new DrinkIngredient { DrinkIngredientId = 10, DrinkId = 3, IngredientId = 20, Amount = "3 slices" },
                  new DrinkIngredient { DrinkIngredientId = 11, DrinkId = 4, IngredientId = 5, Amount = "4cl" },
                  new DrinkIngredient { DrinkIngredientId = 12, DrinkId = 4, IngredientId = 6, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 13, DrinkId = 4, IngredientId = 11, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 14, DrinkId = 4, IngredientId = 21, Amount = "For the rim" },
                  new DrinkIngredient { DrinkIngredientId = 15, DrinkId = 4, IngredientId = 19, Amount = "Fill as desired" },
                  new DrinkIngredient { DrinkIngredientId = 16, DrinkId = 5, IngredientId = 4, Amount = "3cl" },
                  new DrinkIngredient { DrinkIngredientId = 17, DrinkId = 5, IngredientId = 6, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 18, DrinkId = 5, IngredientId = 11, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 19, DrinkId = 5, IngredientId = 14, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 20, DrinkId = 6, IngredientId = 1, Amount = "5cl" },
                  new DrinkIngredient { DrinkIngredientId = 21, DrinkId = 6, IngredientId = 16, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 22, DrinkId = 6, IngredientId = 22, Amount = "1-3" },
                  new DrinkIngredient { DrinkIngredientId = 23, DrinkId = 7, IngredientId = 4, Amount = "5cl" },
                  new DrinkIngredient { DrinkIngredientId = 24, DrinkId = 7, IngredientId = 16, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 25, DrinkId = 7, IngredientId = 22, Amount = "1-3" },
                  new DrinkIngredient { DrinkIngredientId = 26, DrinkId = 8, IngredientId = 3, Amount = "4cl" },
                  new DrinkIngredient { DrinkIngredientId = 27, DrinkId = 8, IngredientId = 11, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 28, DrinkId = 8, IngredientId = 15, Amount = "0.5cl" },
                  new DrinkIngredient { DrinkIngredientId = 29, DrinkId = 8, IngredientId = 23, Amount = "3" },
                  new DrinkIngredient { DrinkIngredientId = 30, DrinkId = 9, IngredientId = 17, Amount = "4cl" },
                  new DrinkIngredient { DrinkIngredientId = 31, DrinkId = 9, IngredientId = 12, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 32, DrinkId = 9, IngredientId = 24, Amount = "1 teaspoon" },
                  new DrinkIngredient { DrinkIngredientId = 33, DrinkId = 10, IngredientId = 3, Amount = "4cl" },
                  new DrinkIngredient { DrinkIngredientId = 34, DrinkId = 10, IngredientId = 15, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 35, DrinkId = 10, IngredientId = 11, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 36, DrinkId = 11, IngredientId = 5, Amount = "2cl" },
                  new DrinkIngredient { DrinkIngredientId = 37, DrinkId = 11, IngredientId = 13, Amount = "1cl" },
                  new DrinkIngredient { DrinkIngredientId = 38, DrinkId = 11, IngredientId = 8, Amount = "4cl" }


                  );







        }


    }
}
