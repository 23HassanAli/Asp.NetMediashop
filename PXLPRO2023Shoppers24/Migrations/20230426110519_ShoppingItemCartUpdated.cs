using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PXLPRO2023Shoppers24.Migrations
{
    public partial class ShoppingItemCartUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Smartphones_SmartphoneId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Smartphones_SmartphoneId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_SmartphoneId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_SmartphoneId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "SmartphoneId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "SmartphoneId",
                table: "OrderItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SmartphoneId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SmartphoneId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SmartphoneId",
                table: "ShoppingCartItems",
                column: "SmartphoneId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_SmartphoneId",
                table: "OrderItems",
                column: "SmartphoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Smartphones_SmartphoneId",
                table: "OrderItems",
                column: "SmartphoneId",
                principalTable: "Smartphones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Smartphones_SmartphoneId",
                table: "ShoppingCartItems",
                column: "SmartphoneId",
                principalTable: "Smartphones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
