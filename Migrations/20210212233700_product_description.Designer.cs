﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OPG.Models;

namespace OPG.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210212233700_product_description")]
    partial class product_description
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("OPG.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Fruit"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Vegetables"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Dairy products and eggs"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Animal products"
                        });
                });

            modelBuilder.Entity("OPG.Models.OrderForm", b =>
                {
                    b.Property<int>("OrderFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderFormId");

                    b.ToTable("OrderForms");
                });

            modelBuilder.Entity("OPG.Models.OrderFormDetail", b =>
                {
                    b.Property<int>("OrderFormDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderFormId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderFormDetailId");

                    b.HasIndex("OrderFormId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderFormDetails");
                });

            modelBuilder.Entity("OPG.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/apple.jpg",
                            Name = "Apple",
                            Price = 10m,
                            ProductDescription = "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance. Their skin may be green, yellow or reddish, and the meat taste ranges from a bitter to sweet flavour. It is one of the most consumed fruit in the world"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/pear.jpg",
                            Name = "Pear ",
                            Price = 10m,
                            ProductDescription = "The pear is a fruit that has expanded all over the world; it is consumed both fresh as cooked, and that is available all throughout the year. There are multiple varieties cultivated, ranging in shape, size and colour."
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/lemon.jpg",
                            Name = "Lemon ",
                            Price = 14m,
                            ProductDescription = "The lemon is rounded and slightly elongated, it belongs to the family of citrus fruit and therefore it shares many of the characteristics of other species of citruses. The skin is yellow. It is used fresh for cooking, and its juice is used in the industry for processed foodstuffs."
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/orange.jpg",
                            Name = "Orange ",
                            Price = 9m,
                            ProductDescription = "Oranges are highly valued for their vitamin C content. This wonderful fruit has more to offer nutritionally than just this one nutrient. Most of the consumption of oranges is in the form of juice. "
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/plum.jpg",
                            Name = "Plum ",
                            Price = 5m,
                            ProductDescription = "The plum is a stone fruit, rounded or elongated that can be yellow, green, red or purple. In general, it is very nutritious and rich in vitamins, specially vitamin C. It is more or less juicy depending on its water content."
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/strawberry.jpg",
                            Name = "Strawberry ",
                            Price = 20m,
                            ProductDescription = "Strawberries are highly appreciated for their pleasant aroma and as an appetite stimulator. It is rich in basic minerals, which confers it the property to stimulate the metabolism. It is eaten raw and used to make jam."
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/blackberry.jpg",
                            Name = "Blackberry ",
                            Price = 25m,
                            ProductDescription = "Blackberries contain a wide array of important nutrients including potassium, magnesium and calcium, as well as vitamins A, C, E and most of our B vitamins. They are also a rich source of anthocyanins, powerful antioxidants that give blackberries their deep purple colour."
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/raspberry.jpg",
                            Name = "Raspberry ",
                            Price = 28m,
                            ProductDescription = "Raspberries are a delicious fruit that are often described as being both tart and sweet. The riper that they are, the sweeter they will taste and the more intense their flavor will be."
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/blueberry.jpg",
                            Name = "Blueberry ",
                            Price = 28m,
                            ProductDescription = "The blueberry pulp is aromatic, juicy and somewhat acid. It contains multiple small brown seeds. In the upper part, this fruit has a small crown that differentiates it from the black currant."
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/grape.jpg",
                            Name = "Grape ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/watermelon.jpg",
                            Name = "Watermelon ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/cherry.jpg",
                            Name = "Cherry",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/potato.jpg",
                            Name = "Potato",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/tomato.jpg",
                            Name = "Tomato ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/salad.jpg",
                            Name = "Salad ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/onion.jpg",
                            Name = "Onion",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/broccoli.jpg",
                            Name = "Broccoli ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/cauliflower.jpg",
                            Name = "Cauliflower ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/cucumbers.jpg",
                            Name = "Cucumber",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/spinach.jpeg",
                            Name = "Spinach ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/radish.jpg",
                            Name = "Radish ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/celery.jpg",
                            Name = "Celery ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/beans.jpg",
                            Name = "Beans ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/carrot.jpg",
                            Name = "Carrot",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 25,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/eggplant.jpg",
                            Name = "Eggplant ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 26,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/cheese.jpg",
                            Name = "Cheese ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 27,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/yogurt.jpg",
                            Name = "Yogurt ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 28,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/milk.jpg",
                            Name = "Milk ",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 29,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/eggs.jpg",
                            Name = "Eggs",
                            Price = 0m,
                            ProductDescription = ""
                        },
                        new
                        {
                            ProductId = 30,
                            CategoryId = 4,
                            Discount = 0f,
                            ImageUrl = "/images/tuna.jpg",
                            Name = "Tuna",
                            Price = 0m,
                            ProductDescription = ""
                        });
                });

            modelBuilder.Entity("OPG.Models.OrderFormDetail", b =>
                {
                    b.HasOne("OPG.Models.OrderForm", "OrderForm")
                        .WithMany("OrderFormDetails")
                        .HasForeignKey("OrderFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPG.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderForm");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.OrderItem", b =>
                {
                    b.HasOne("OPG.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.HasOne("OPG.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OPG.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.OrderForm", b =>
                {
                    b.Navigation("OrderFormDetails");
                });
#pragma warning restore 612, 618
        }
    }
}