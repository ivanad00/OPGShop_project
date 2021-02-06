using Microsoft.EntityFrameworkCore.Migrations;

namespace OPG.Migrations
{
    public partial class RemovedSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.AddColumn<string>(
                name: "Allowed",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allowed",
                table: "Payment");

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oib = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.SellerId);
                    table.ForeignKey(
                        name: "FK_Seller_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "SellerId", "CompanyName", "Oib", "UserId" },
                values: new object[] { 1, "OPG1", 123456789, null });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "SellerId", "CompanyName", "Oib", "UserId" },
                values: new object[] { 2, "OPG2", 123456789, null });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "SellerId", "CompanyName", "Oib", "UserId" },
                values: new object[] { 3, "OPG3", 123456789, null });

            migrationBuilder.CreateIndex(
                name: "IX_Seller_UserId",
                table: "Seller",
                column: "UserId");
        }
    }
}
