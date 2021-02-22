using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "OrderForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "OrderForms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderForms_UserId1",
                table: "OrderForms",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderForms_AspNetUsers_UserId1",
                table: "OrderForms",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderForms_AspNetUsers_UserId1",
                table: "OrderForms");

            migrationBuilder.DropIndex(
                name: "IX_OrderForms_UserId1",
                table: "OrderForms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderForms");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "OrderForms");
        }
    }
}
