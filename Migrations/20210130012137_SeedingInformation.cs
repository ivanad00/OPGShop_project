using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class SeedingInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderProduct",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Fruit" },
                    { 2, "Vegetables" },
                    { 3, "Dairy products and eggs" },
                    { 4, "Animal products" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "ArrivalTime", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.3m, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5m, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.6m, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.3m, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6m, null }
                });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderProductId", "OrderId", "Price", "ProductId" },
                values: new object[,]
                {
                    { 4, null, 6.6m, null },
                    { 3, null, 5.5m, null },
                    { 5, null, 5.2m, null },
                    { 1, null, 2.3m, null },
                    { 2, null, 4.6m, null }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "OrderId", "PaymentType" },
                values: new object[,]
                {
                    { 1, null, "Paypal" },
                    { 2, null, "Credit Card" }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "Note", "ProductId", "UserId" },
                values: new object[,]
                {
                    { 1, "this is good", null, null },
                    { 2, "this product is 3/10", null, null },
                    { 3, "this product is 10/10", null, null }
                });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "SellerId", "CompanyName", "Oib", "UserId" },
                values: new object[,]
                {
                    { 1, "OPG1", 123456789, null },
                    { 2, "OPG2", 123456789, null },
                    { 3, "OPG3", 123456789, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Adress1", "Adress2", "City", "Country", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "SellerId", "ZipCode" },
                values: new object[,]
                {
                    { 4, "Ruđera Boškovića 24", null, "Split", "Hrvatska", null, "Zoran", "Nikolić", null, null, "Customer", 0, 21000 },
                    { 1, "Ruđera Boškovića 28", null, "Split", "Hrvatska", null, "Ivan", "Ivanović", null, null, "Seller", 1, 21000 },
                    { 2, "Ruđera Boškovića 20", null, "Split", "Hrvatska", null, "Nikola", "Nikolić", null, null, "Customer", 0, 21000 },
                    { 3, "Ruđera Boškovića 23", null, "Split", "Hrvatska", null, "Ivana", "Ivanović", null, null, "Seller", 2, 21000 },
                    { 5, "Ruđera Boškovića 30", null, "Split", "Hrvatska", null, "Josipa", "Ivanović", null, null, "Customer", 0, 21000 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Discount", "ImageUrl", "Name", "ProductDescription", "UserId" },
                values: new object[,]
                {
                    { 2, 2, 0f, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "Carrot", null, 1 },
                    { 1, 1, 0f, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "Apple ", null, 2 },
                    { 3, 3, 0f, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "Eggs", null, 3 },
                    { 4, 4, 0f, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "Tuna", null, 4 },
                    { 5, 2, 0f, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "Potato", null, 5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "OrderProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "SellerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "SellerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "SellerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "OrderProduct",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
