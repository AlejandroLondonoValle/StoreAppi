using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreAppi.Models;

namespace StoreAppi.Seeders
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    Id = 1,
                    Name = "Bebidas",
                },
                new Category
                {
                    Id = 2,
                    Name = "Comidas",
                },
                new Category
                {
                    Id = 3,
                    Name = "Postres",
                },
                new Category
                {
                    Id = 4,
                    Name = "Entradas",
                },
                new Category
                {
                    Id = 5,
                    Name = "Domicilios",
                }
            );
        }
    }
}
