using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class OrderProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "OrderProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId1",
                table: "OrderProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId1",
                table: "OrderProduct",
                column: "OrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderId1",
                table: "OrderProduct",
                column: "OrderId1",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId1",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_OrderId1",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "OrderProduct");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderProduct",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
