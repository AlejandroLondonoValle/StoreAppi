// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using StoreAppi.Models;

// namespace StoreAppi.Seeders
// {
//     public class UserSeeder
//     {
//         public static void Seed(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<User>().HasData(
                
//                 new User
//                 {
//                     Id = 4,
//                     Name = "Alejandro Londoño",
//                     Email = "Alejandro@gmail.com",
//                     Password = PasswordHasher.HashPassword("12345678"), 
//                     Phone = "3123456789",
//                     Address = "Cra 45 67 89",
//                     Role = "admin"
//                 },
//                 new User
//                 {   
//                     Id = 5,
//                     Name = "Kevin Alvarez",
//                     Email = "kev@gmail.com",
//                     Password = PasswordHasher.HashPassword("987654321"),
//                     Phone = "3132145678",
//                     Address = "Cra 40 50 60",
//                     Role = "admin"
//                 },
//                 new User
//                 {
//                     Id = 6,
//                     Name = "Laura Jimenez",
//                     Email = "laura.jimenez@restadmin.com",
//                     Password = PasswordHasher.HashPassword("laura2024"),
//                     Phone = "3221234567",
//                     Address = "Cra 55 33 44",
//                     Role = "customer"
//                 }
//             );
//         }    
//     }
// }
