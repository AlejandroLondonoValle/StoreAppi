using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreAppi.Models;

namespace StoreAppi.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Coca cola 400ml",
                    Price = 3500,
                    Cost = 2100,
                    Category_id = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Hamburguesa",
                    Price = 18000,
                    Cost = 9000,
                    Category_id = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Pizza Peperoni",
                    Price = 22000,
                    Cost = 12000,
                    Category_id = 2
                },
                new Product
                {
                    Id = 4,
                    Name = "Postobon 1.5lt",
                    Price = 7000,
                    Cost = 3500,
                    Category_id = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Michelada clasica",
                    Price = 5000,
                    Cost = 2500,
                    Category_id = 1
                },
                new Product
                {
                    Id = 6,
                    Name = "Michelada cereza",
                    Price = 7000,
                    Cost = 3500,
                    Category_id = 1
                },
                new Product
                {
                    Id = 7,
                    Name = "Bruschetta",
                    Price = 12000,
                    Cost = 5000,
                    Category_id = 4
                },
                new Product
                {
                    Id = 8,
                    Name = "Tacos al Pastor",
                    Price = 25000,
                    Cost = 12000,
                    Category_id = 4
                },
                new Product
                {
                    Id = 9,
                    Name = "Ceviche",
                    Price = 7000,
                    Cost = 3500,
                    Category_id = 4
                },
                new Product
                {
                    Id = 10,
                    Name = "Cheesecake",
                    Price = 7000,
                    Cost = 3500,
                    Category_id = 3
                },
                new Product
                {
                    Id = 11,
                    Name = "Brownie",
                    Price = 6000,
                    Cost = 3500,
                    Category_id = 3
                },
                new Product
                {
                    Id = 12,
                    Name = "Tiramisu",
                    Price = 7000,
                    Cost = 3500,
                    Category_id = 3
                }

            );
        }
    }
}