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
        public DbSet<OrderForm> OrderForms { get; set; }
        public DbSet<OrderFormDetail> OrderFormDetails { get; set; }
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            //seed categories
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 1, Name = "Fruit" } );
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 2, Name = "Vegetables" } );
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 3, Name = "Dairy products and eggs" } );
            modelBuilder.Entity<Category> ().HasData ( new Category { CategoryId = 4, Name = "Animal products" } );

            //seed products
            //fruit
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Apple",
                CategoryId = 1,
                ImageUrl = "/images/apple.jpg",
                ProductDescription = "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance. Their skin may be green, yellow or reddish, and the meat taste ranges from a bitter to sweet flavour. It is one of the most consumed fruit in the world",
                Price=10

            }) ;

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Pear ",
                CategoryId = 1,
                ImageUrl = "/images/pear.jpg",
                ProductDescription = "The pear is a fruit that has expanded all over the world; it is consumed both fresh as cooked, and that is available all throughout the year. There are multiple varieties cultivated, ranging in shape, size and colour.",
                Price = 10
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Lemon ",
                CategoryId = 1,
                ImageUrl = "/images/lemon.jpg",
                ProductDescription = "The lemon is rounded and slightly elongated, it belongs to the family of citrus fruit and therefore it shares many of the characteristics of other species of citruses. The skin is yellow. It is used fresh for cooking, and its juice is used in the industry for processed foodstuffs.",
                Price = 14

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Orange ",
                CategoryId = 1,
                ImageUrl = "/images/orange.jpg",
                ProductDescription = "Oranges are highly valued for their vitamin C content. This wonderful fruit has more to offer nutritionally than just this one nutrient. Most of the consumption of oranges is in the form of juice. ",
                Price=9

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Plum ",
                CategoryId = 1,
                ImageUrl = "/images/plum.jpg",
                ProductDescription = "The plum is a stone fruit, rounded or elongated that can be yellow, green, red or purple. In general, it is very nutritious and rich in vitamins, specially vitamin C. It is more or less juicy depending on its water content.",
                Price=5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Strawberry ",
                CategoryId = 1,
                ImageUrl = "/images/strawberry.jpg",
                ProductDescription = "Strawberries are highly appreciated for their pleasant aroma and as an appetite stimulator. It is rich in basic minerals, which confers it the property to stimulate the metabolism. It is eaten raw and used to make jam.",
                Price =20

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Blackberry ",
                CategoryId = 1,
                ImageUrl = "/images/blackberry.jpg",
                ProductDescription = "Blackberries contain a wide array of important nutrients including potassium, magnesium and calcium, as well as vitamins A, C, E and most of our B vitamins. They are also a rich source of anthocyanins, powerful antioxidants that give blackberries their deep purple colour.",
                Price=25

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Raspberry ",
                CategoryId = 1,
                ImageUrl = "/images/raspberry.jpg",
                ProductDescription = "Raspberries are a delicious fruit that are often described as being both tart and sweet. The riper that they are, the sweeter they will taste and the more intense their flavor will be.",
                Price=28

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Blueberry ",
                CategoryId = 1,
                ImageUrl = "/images/blueberry.jpg",
                ProductDescription = "The blueberry pulp is aromatic, juicy and somewhat acid. It contains multiple small brown seeds. In the upper part, this fruit has a small crown that differentiates it from the black currant.",
                Price=28

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Grape ",
                CategoryId = 1,
                ImageUrl = "/images/grape.jpg",
                ProductDescription = "The grape is a fruit that grows in tight clusters. It has a white or purple flesh of sweet taste, eaten raw or in juice, although it is chiefly used for making wine. It contains various minerals and vitamins, and it is considered to be antioxidant and anti-carcinogenic.",
                Price=5

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Watermelon ",
                CategoryId = 1,
                ImageUrl = "/images/watermelon.jpg",
                ProductDescription = "The watermelon is a large fruit of a more or less spherical shape. It is usually eaten raw as table dessert. It has a sweet reddish or yellowish flesh. It is a very refreshing food that supplies very few calories. It also provides some vitamins and minerals.",
                Price=5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Cherry",
                CategoryId = 1,
                ImageUrl = "/images/cherryy.jpg",
                ProductDescription = "The cherry is a fruit that is consumed fresh or in cakes, mousses, jams and fruit stews. The larger cherries are usually the ones with better taste and texture.",
                Price=10

            });


            //vegetables
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 13,
                Name = "Potato",
                CategoryId = 2,
                ImageUrl = "/images/potato.jpg",
                ProductDescription = "The potato is one of the most cultivated products in the world. Its consumption is intended for human feeding in fresh, for cattle feeding and as raw material for the food and agriculture processing industries, such as chips, potato flakes, frozen potatoes, etc",
                Price=6

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 14,
                Name = "Tomato ",
                CategoryId = 2,
                ImageUrl = "/images/tomato.jpg",
                ProductDescription = "The tomato cultivated everywhere in the world. It is consumed in multiple ways, both raw as processed for the industry. At present there exists a great range of varieties, cultivated all the year round, with fruits of different sizes, shapes and colours. Besides, it is rich in fibre and low in calories, supplying vitamins and minerals.",
                Price=8

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 15,
                Name = "Salad ",
                CategoryId = 2,
                ImageUrl = "/images/salad.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 16,
                Name = "Onion",
                CategoryId = 2,
                ImageUrl = "/images/onion.jpg",
                ProductDescription = "The onion is an underground, eadible bulb that grows in the plant that bears the same name. There is a wide range of varieties, that can be classified according to the colour of the bulb, the shape, size, use, origin and earliness. It is used in many ways for cooking, both raw and cooked. Moreover, it has various medicinal properties.",
                Price=6

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 17,
                Name = "Broccoli ",
                CategoryId = 2,
                ImageUrl = "/images/broccoli.jpg",
                ProductDescription = "The broccoli is a vegetable that belongs the cabbage family. Its consumption increases constantly, since it is a healthy food with multiple culinary uses. It has a pleasant taste and it is rich in mineral and vitamins. It is also low in calories.",
                Price=20

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 18,
                Name = "Cauliflower ",
                CategoryId = 2,
                ImageUrl = "/images/cauliflower.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 19,
                Name = "Cucumber",
                CategoryId = 2,
                ImageUrl = "/images/cucumbers.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 20,
                Name = "Spinach ",
                CategoryId = 2,
                ImageUrl = "/images/spinach.jpeg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 21,
                Name = "Radish ",
                CategoryId = 2,
                ImageUrl = "/images/radish.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 22,
                Name = "Celery ",
                CategoryId = 2,
                ImageUrl = "/images/celery.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 23,
                Name = "Beans ",
                CategoryId = 2,
                ImageUrl = "/images/beans.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Carrot",
                CategoryId = 2,
                ImageUrl = "/images/carrot.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 25,
                Name = "Eggplant ",
                CategoryId = 2,
                ImageUrl = "/images/eggplant.jpg",
                ProductDescription = ""

            });





            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 26,
                Name = "Cheese ",
                CategoryId = 3,
                ImageUrl = "/images/cheese.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 27,
                Name = "Yogurt ",
                CategoryId = 3,
                ImageUrl = "/images/yogurt.jpg",
                ProductDescription = ""

            });
            modelBuilder.Entity<Product> ().HasData ( new Product
            {
                ProductId = 28,
                Name = "Milk ",
                CategoryId = 3,
                ImageUrl = "/images/milk.jpg",
                ProductDescription = ""

            });


            //other
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 29,
                Name = "Eggs",
                CategoryId = 3,
                ImageUrl = "/images/eggs.jpg",
                ProductDescription = ""

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 30,
                Name = "Tuna",
                CategoryId = 4,
                ImageUrl = "/images/tuna.jpg",
                ProductDescription = ""


            });
        }

    }

}

