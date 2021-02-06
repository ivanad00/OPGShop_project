using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Discount", "ImageUrl", "Name", "Price", "ProductDescription", "UserId" },
                values: new object[,]
                {
                    { 6, 2, 0f, "", "Tomato ", 0m, null, 2 },
                    { 28, 3, 0f, "", "Milk ", 0m, null, 1 },
                    { 27, 3, 0f, "", "Yogurt ", 0m, null, 2 },
                    { 26, 3, 0f, "", "Cheese ", 0m, null, 3 },
                    { 25, 1, 0f, "", "Watermelon ", 0m, null, 2 },
                    { 24, 1, 0f, "", "Plum ", 0m, null, 1 },
                    { 23, 1, 0f, "", "Grape ", 0m, null, 2 },
                    { 22, 1, 0f, "", "Blueberry ", 0m, null, 2 },
                    { 21, 1, 0f, "", "Raspberry ", 0m, null, 4 },
                    { 20, 1, 0f, "", "Blackberry ", 0m, null, 1 },
                    { 19, 1, 0f, "", "Strawberry ", 0m, null, 3 },
                    { 29, 1, 0f, "", "Cherry", 0m, null, 2 },
                    { 18, 1, 0f, "", "Lemon ", 0m, null, 2 },
                    { 16, 1, 0f, "", "Pear ", 0m, null, 2 },
                    { 15, 2, 0f, "", "Beans ", 0m, null, 1 },
                    { 14, 2, 0f, "", "Celery ", 0m, null, 3 },
                    { 13, 2, 0f, "", "Radish ", 0m, null, 1 },
                    { 12, 2, 0f, "", "Spinach ", 0m, null, 2 },
                    { 11, 2, 0f, "", "Cucumber", 0m, null, 2 },
                    { 10, 1, 0f, "", "Cauliflower ", 0m, null, 2 },
                    { 9, 2, 0f, "", "Broccoli ", 0m, null, 4 },
                    { 8, 2, 0f, "", "Onion", 0m, null, 3 },
                    { 7, 2, 0f, "", "Salad ", 0m, null, 2 },
                    { 17, 1, 0f, "", "Orange ", 0m, null, 4 },
                    { 30, 2, 0f, "", "Eggplant ", 0m, null, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 30);
        }
    }
}
