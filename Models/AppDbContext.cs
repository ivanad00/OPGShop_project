using Microsoft.EntityFrameworkCore;

namespace OPG.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext ( DbContextOptions<AppDbContext> options ) : base ( options )
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            //seed categories
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 1, Name = "Fruit" } );
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 2, Name = "Vegetables" } );
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 3, Name = "Dairy products and eggs" } );
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 4, Name = "Animal products" } );

            //seed products
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 1,
                Name = "Apple",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 2,
                Name = "Carrot",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 3,
                Name = "Eggs",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 4,
                Name = "Tuna",
                CategoryId = 4,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 5,
                Name = "Potato",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 6,
                Name = "Tomato ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 7,
                Name = "Salad ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 8,
                Name = "Onion",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 9,
                Name = "Broccoli ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 10,
                Name = "Cauliflower ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 11,
                Name = "Cucumber",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 12,
                Name = "Spinach ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 13,
                Name = "Radish ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 14,
                Name = "Celery ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 15,
                Name = "Beans ",
                CategoryId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 16,
                Name = "Pear ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 17,
                Name = "Orange ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 18,
                Name = "Lemon ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 19,
                Name = "Strawberry ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 20,
                Name = "Blackberry ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 21,
                Name = "Raspberry ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 22,
                Name = "Blueberry ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 23,
                Name = "Grape ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 24,
                Name = "Plum ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 25,
                Name = "Watermelon ",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 26,
                Name = "Cheese ",
                CategoryId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 27,
                Name = "Yogurt ",
                CategoryId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 28,
                Name = "Milk ",
                CategoryId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 29,
                Name = "Cherry",
                CategoryId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 30,
                Name = "Eggplant ",
                CategoryId = 2,
                ImageUrl = "",
            } );
          
        }

    }

}

