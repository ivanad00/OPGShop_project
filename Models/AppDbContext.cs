using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OPG.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Product> Order_Product { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Users> User { get; set; }
    }

    
}
