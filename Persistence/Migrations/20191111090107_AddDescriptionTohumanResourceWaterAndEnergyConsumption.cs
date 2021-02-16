using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddDescriptionTohumanResourceWaterAndEnergyConsumption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "HumanResources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EnergyConsumptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "HumanResources");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EnergyConsumptions");
        }
    }
}
