using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PXLPRO2023Shoppers24.Migrations
{
    public partial class gsmidChangedToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GsmId",
                table: "Smartphones",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Smartphones",
                newName: "GsmId");
        }
    }
}
