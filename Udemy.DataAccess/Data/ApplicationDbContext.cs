﻿using Microsoft.EntityFrameworkCore;
using UdemyBook.Models;

namespace UdemyBook.DataAcess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue.",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue.",
                    ISBN = "CAW777777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                },
                 new Product
                 {
                     Id = 3,
                     Title = "Vanish in the Sunset",
                     Author = "Julian Button",
                     Description = "Praesent vitae sodales libero. Praesent molestie orci augue.",
                     ISBN = "RITO5555501",
                     ListPrice = 55,
                     Price = 50,
                     Price50 = 40,
                     Price100 = 35,
                 },
                  new Product
                  {
                      Id = 4,
                      Title = "Cotton Candy",
                      Author = "Abby Muscles",
                      Description = "Praesent vitae sodales libero. Praesent molestie orci augue.",
                      ISBN = "WS333333301",
                      ListPrice = 70,
                      Price = 65,
                      Price50 = 60,
                      Price100 = 55,
                  },
                   new Product
                   {
                       Id = 5,
                       Title = "Rock in the Ocean",
                       Author = "Ron Parker",
                       Description = "Praesent vitae sodales libero. Praesent molestie orci augue.",
                       ISBN = "SOTJ111111101",
                       ListPrice = 30,
                       Price = 27,
                       Price50 = 25,
                       Price100 = 20,
                   },
                    new Product
                    {
                        Id = 6,
                        Title = "Leaves and Wonders",
                        Author = "Billy Spark",
                        Description = "Praesent vitae sodales libero. Praesent molestie orci augue.",
                        ISBN = "FOT000000001",
                        ListPrice = 25,
                        Price = 23,
                        Price50 = 22,
                        Price100 = 20,
                    }
                );
        }
    }
}