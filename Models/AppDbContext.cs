using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Http;

namespace OPG.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext ( DbContextOptions<AppDbContext> options ) : base ( options )
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Rating> Rating { get; set; }

        public DbSet<User> User  { get; set; }
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
                Name = "Apple ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 2,
                Name = "Carrot",
                CategoryId = 2,
                UserId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 3,
                Name = "Eggs",
                CategoryId = 3,
                UserId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 4,
                Name = "Tuna",
                CategoryId = 4,
                UserId = 4,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 5,
                Name = "Potato",
                CategoryId = 2,
                UserId = 5,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 6,
                Name = "Tomato ",
                CategoryId = 2,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 7,
                Name = "Salad ",
                CategoryId = 2,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 8,
                Name = "Onion",
                CategoryId = 2,
                UserId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 9,
                Name = "Broccoli ",
                CategoryId = 2,
                UserId = 4,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 10,
                Name = "Cauliflower ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 11,
                Name = "Cucumber",
                CategoryId = 2,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 12,
                Name = "Spinach ",
                CategoryId = 2,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 13,
                Name = "Radish ",
                CategoryId = 2,
                UserId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 14,
                Name = "Celery ",
                CategoryId = 2,
                UserId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 15,
                Name = "Beans ",
                CategoryId = 2,
                UserId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 16,
                Name = "Pear ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 17,
                Name = "Orange ",
                CategoryId = 1,
                UserId = 4,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 18,
                Name = "Lemon ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 19,
                Name = "Strawberry ",
                CategoryId = 1,
                UserId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 20,
                Name = "Blackberry ",
                CategoryId = 1,
                UserId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 21,
                Name = "Raspberry ",
                CategoryId = 1,
                UserId = 4,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 22,
                Name = "Blueberry ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 23,
                Name = "Grape ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 24,
                Name = "Plum ",
                CategoryId = 1,
                UserId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 25,
                Name = "Watermelon ",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 26,
                Name = "Cheese ",
                CategoryId = 3,
                UserId = 3,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 27,
                Name = "Yogurt ",
                CategoryId = 3,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 28,
                Name = "Milk ",
                CategoryId = 3,
                UserId = 1,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 29,
                Name = "Cherry",
                CategoryId = 1,
                UserId = 2,
                ImageUrl = "",
            } );
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 30,
                Name = "Eggplant ",
                CategoryId = 2,
                UserId = 4,
                ImageUrl = "",
            } );
            //seed users
            modelBuilder.Entity<User> ().HasData ( new User
            {
                UserId = 1,
                FirstName = "Ivan",
                LastName = "Ivanović",
                Role = "Seller",
                SellerId = 1,
                Adress1 = "Ruđera Boškovića 28",
                City = "Split",
                ZipCode = 21000,
                Country = "Hrvatska"
            } );
            modelBuilder.Entity<User> ().HasData ( new User
            {
                UserId = 2,
                FirstName = "Nikola",
                LastName = "Nikolić",
                Role = "Customer",
                Adress1 = "Ruđera Boškovića 20",
                City = "Split",
                ZipCode = 21000,
                Country = "Hrvatska"
            } );
            modelBuilder.Entity<User> ().HasData ( new User
            {
                UserId = 3,
                FirstName = "Ivana",
                LastName = "Ivanović",
                Role = "Seller",
                SellerId = 2,
                Adress1 = "Ruđera Boškovića 23",
                City = "Split",
                ZipCode = 21000,
                Country = "Hrvatska"
            } );
            modelBuilder.Entity<User> ().HasData ( new User
            {
                UserId = 4,
                FirstName = "Zoran",
                LastName = "Nikolić",
                Role = "Customer",
                Adress1 = "Ruđera Boškovića 24",
                City = "Split",
                ZipCode = 21000,
                Country = "Hrvatska"
            } );
            modelBuilder.Entity<User> ().HasData ( new User
            {
                UserId = 5,
                FirstName = "Josipa",
                LastName = "Ivanović",
                Role = "Customer",
                Adress1 = "Ruđera Boškovića 30",
                City = "Split",
                ZipCode = 21000,
                Country = "Hrvatska"
            } );

            ////seed Order
            //modelBuilder.Entity<Order> ().HasData ( new Order
            //{
            //    OrderId = "1",
            //    Price = 2.3m
            //} );
            //modelBuilder.Entity<Order> ().HasData ( new Order
            //{
            //    OrderId = "2",
            //    Price = 3.5m
            //} );
            //modelBuilder.Entity<Order> ().HasData ( new Order
            //{
            //    OrderId = "3",
            //    Price = 5.6m
            //} );
            //modelBuilder.Entity<Order> ().HasData ( new Order
            //{
            //    OrderId = "4",
            //    Price = 2.3m
            //} );
            //modelBuilder.Entity<Order> ().HasData ( new Order
            //{
            //    OrderId = "5",
            //    Price = 3.6m
            //} );

            //seed orderproduct
            modelBuilder.Entity<OrderProduct> ().HasData ( new OrderProduct
            {
                OrderProductId = 1,
                Price = 2.3m
            } );
            modelBuilder.Entity<OrderProduct> ().HasData ( new OrderProduct
            {
                OrderProductId = 2,
                Price = 4.6m
            } );
            modelBuilder.Entity<OrderProduct> ().HasData ( new OrderProduct
            {
                OrderProductId = 3,
                Price = 5.5m
            } );
            modelBuilder.Entity<OrderProduct> ().HasData ( new OrderProduct
            {
                OrderProductId = 4,
                Price = 6.6m
            } );
            modelBuilder.Entity<OrderProduct> ().HasData ( new OrderProduct
            {
                OrderProductId = 5,
                Price = 5.2m
            } );
            //seed payment
            modelBuilder.Entity<Payment> ().HasData ( new Payment
            {
                PaymentId = 1,
                PaymentType = "Paypal"
            } );
            modelBuilder.Entity<Payment> ().HasData ( new Payment
            {
                PaymentId = 2,
                PaymentType = "Credit Card"
            } );

            //seed rating
            modelBuilder.Entity<Rating> ().HasData ( new Rating
            {
                RatingId = 1,
                Note = "this is good"
            } );
            modelBuilder.Entity<Rating> ().HasData ( new Rating
            {
                RatingId = 2,
                Note = "this product is 3/10"
            } );
            modelBuilder.Entity<Rating> ().HasData ( new Rating
            {
                RatingId = 3,
                Note = "this product is 10/10"
            } );

        }

    }

}

