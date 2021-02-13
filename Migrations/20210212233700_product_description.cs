using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class product_description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 10m, "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance. Their skin may be green, yellow or reddish, and the meat taste ranges from a bitter to sweet flavour. It is one of the most consumed fruit in the world" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 10m, "The pear is a fruit that has expanded all over the world; it is consumed both fresh as cooked, and that is available all throughout the year. There are multiple varieties cultivated, ranging in shape, size and colour." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 14m, "The lemon is rounded and slightly elongated, it belongs to the family of citrus fruit and therefore it shares many of the characteristics of other species of citruses. The skin is yellow. It is used fresh for cooking, and its juice is used in the industry for processed foodstuffs." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 9m, "Oranges are highly valued for their vitamin C content. This wonderful fruit has more to offer nutritionally than just this one nutrient. Most of the consumption of oranges is in the form of juice. " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 5m, "The plum is a stone fruit, rounded or elongated that can be yellow, green, red or purple. In general, it is very nutritious and rich in vitamins, specially vitamin C. It is more or less juicy depending on its water content." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 20m, "Strawberries are highly appreciated for their pleasant aroma and as an appetite stimulator. It is rich in basic minerals, which confers it the property to stimulate the metabolism. It is eaten raw and used to make jam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 25m, "Blackberries contain a wide array of important nutrients including potassium, magnesium and calcium, as well as vitamins A, C, E and most of our B vitamins. They are also a rich source of anthocyanins, powerful antioxidants that give blackberries their deep purple colour." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 28m, "Raspberries are a delicious fruit that are often described as being both tart and sweet. The riper that they are, the sweeter they will taste and the more intense their flavor will be." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 28m, "The blueberry pulp is aromatic, juicy and somewhat acid. It contains multiple small brown seeds. In the upper part, this fruit has a small crown that differentiates it from the black currant." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Price", "ProductDescription" },
                values: new object[] { 0m, "" });
        }
    }
}
