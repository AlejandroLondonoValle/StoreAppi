using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreAppi.Models;

namespace StoreAppi.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}
