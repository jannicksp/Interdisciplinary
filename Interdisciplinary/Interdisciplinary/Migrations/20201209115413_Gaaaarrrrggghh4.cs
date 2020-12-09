using Microsoft.EntityFrameworkCore.Migrations;

namespace Interdisciplinary.Migrations
{
    public partial class Gaaaarrrrggghh4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "IngredientsView",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DrinkName",
                table: "IngredientsView",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "IngredientsView");

            migrationBuilder.DropColumn(
                name: "DrinkName",
                table: "IngredientsView");
        }
    }
}
