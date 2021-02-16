using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddKeepingMethodInRawmaterialConsumingmaterialManufaturedProductsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KeepingMethod",
                table: "RawMaterials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeepingMethod",
                table: "ManufacturedProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeepingMethod",
                table: "ConsumingMaterials",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeepingMethod",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "KeepingMethod",
                table: "ManufacturedProducts");

            migrationBuilder.DropColumn(
                name: "KeepingMethod",
                table: "ConsumingMaterials");
        }
    }
}
