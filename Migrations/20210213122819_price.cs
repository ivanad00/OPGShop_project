using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 5m, "The grape is a fruit that grows in tight clusters. It has a white or purple flesh of sweet taste, eaten raw or in juice, although it is chiefly used for making wine. It contains various minerals and vitamins, and it is considered to be antioxidant and anti-carcinogenic." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 5m, "The watermelon is a large fruit of a more or less spherical shape. It is usually eaten raw as table dessert. It has a sweet reddish or yellowish flesh. It is a very refreshing food that supplies very few calories. It also provides some vitamins and minerals." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "ImageUrl", "Price", "ProductDescription" },
                values: new object[] { "/images/cherryy.jpg", 20m, "The cherry is a fruit that is consumed fresh or in cakes, mousses, jams and fruit stews. The larger cherries are usually the ones with better taste and texture." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 6m, "The potato is one of the most cultivated products in the world. Its consumption is intended for human feeding in fresh, for cattle feeding and as raw material for the food and agriculture processing industries, such as chips, potato flakes, frozen potatoes, etc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 8m, "The tomato cultivated everywhere in the world. It is consumed in multiple ways, both raw as processed for the industry. At present there exists a great range of varieties, cultivated all the year round, with fruits of different sizes, shapes and colours. Besides, it is rich in fibre and low in calories, supplying vitamins and minerals." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 5m, "Green Leaf lettuce is best suited for fresh applications and is most commonly used as a wrap, garnish, in salads, or as a layer in a sandwich. It is crisp and has a sweet or bitter smell when the stalk is scratched, depending on the specific variety" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 6m, "The onion is an underground, eadible bulb that grows in the plant that bears the same name. There is a wide range of varieties, that can be classified according to the colour of the bulb, the shape, size, use, origin and earliness. It is used in many ways for cooking, both raw and cooked. Moreover, it has various medicinal properties." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 20m, "The broccoli is a vegetable that belongs the cabbage family. Its consumption increases constantly, since it is a healthy food with multiple culinary uses. It has a pleasant taste and it is rich in mineral and vitamins. It is also low in calories." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 12m, "The cauliflower is a vegetable that belongs to the cabbage family. The part that one consumes is the flower or inflorescence, highly appreciated for its taste. It can be presented in many ways, both raw and cooked. It is an important source of vitamins and minerals. In addition, it contributes with fibber and it is low in calories." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 7m, "Cucumber is a summer vegetable with elongate shape. Its skin is of a green colour, turning into yellow in maturation. At present, it is found in the European markets all over the year. Fresh or pickled cucumbers are also available" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 30m, "Spinach is a herbaceous plant whose leaves, green and arranged in rosette, are eaten raw or cooked. The leaves have an oval shape and are wrinkled. It is a very nutritious, tasteful and easy-to-digest plant. Like most of the leafy vegetables, it has a great content of water and a low percentage of proteins, carbohydrates and lipids. It stands out for its high nutritional richness, since its vitamin and mineral content is higher than the rest of vegetables." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 30m, "Radish is the fleshy root that is obtained from the plant with the same name. It has a pungent taste and it is consumed as a vegetable. There are varieties of spherical, conical, cylindrical and oval shape. They are covered by a rind of diverse colours; red, white, purple, black or red and white, although the most frequent varieties are red. " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 30m, "Celery is a vegetable with long petioles, meaty and succulent that are known by the name of stalks. They may be eaten raw in salads or alone, fried, boiled, with sauces and as a condiment for soups, stews, etc. It can also be used as an aromatic and besides the stalks, the leaves and seeds of the plant are used. " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 30m, "Beans are a great source of fiber. They can be cooked in many different ways, including boiling, frying, and baking. Beans are a summer crop that needs warm temperatures to grow and one of the longest-cultivated plants." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 8m, "The carrot is one of the most cultivated vegetables in the world. Its consumption has spreaded widely, since at present it is available all the year round. The part of the carrot that we consume is its root, of which there are various shapes and tastes. It stands out for its carotene and vitamin A, B and C content" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 20m, "Eggplant are members of the same plant family as tomatoes and peppers, but more vunerable to cold temperatures than tomatoes. A large selection of varieties makes eggplants available in several colors and shape, but they are usually purplish black and oval shape." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 60m, "Cheese is a preserved form of milk made by the coagulation, draining or pressing, and salting of the milk proteins and fats. It is popular for its longevity and nutritional value. Cheese is a stable food with a longer shelf life than milk, and it is an affordable food for any budget. There are numerous styles, shapes, tastes, and textures of cheese." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 20m, "The basic production of homemade yogurt is fairly simple: milk is heated and combined with a starter yogurt culture, most often spoonfuls of a batch of yogurt that is already made. The milk mixture is kept at a warm temperature for at least eight hours, letting those cultures bloom, resulting in creamy tasty yogurt." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 8m, "Liquid milk is the most consumed, processed and marketed dairy product. Worldwide, less and less liquid milk is consumed in its raw form." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 2m, "Chicken eggs are the most commonly eaten egg, which are typically classified and sold in four standard sizes. Eggs contain the highest quality protein you can buy." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 70m, "Tuna is a good source of essential nutrients, such as omega-3 fatty acids, high quality protein, selenium and Vitamin D." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "ImageUrl", "Price", "ProductDescription" },
                values: new object[] { "/images/cherry.jpg", 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });
        }
    }
}
