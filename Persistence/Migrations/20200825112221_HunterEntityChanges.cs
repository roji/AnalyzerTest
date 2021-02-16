using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class HunterEntityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistanceToCity",
                table: "Hunter_Addresses");

            migrationBuilder.DropColumn(
                name: "Elevation",
                table: "Hunter_Addresses");

            migrationBuilder.DropColumn(
                name: "IndustrialTown",
                table: "Hunter_Addresses");

            migrationBuilder.DropColumn(
                name: "IsInTownEnv",
                table: "Hunter_Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistanceToCity",
                table: "Hunter_Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Elevation",
                table: "Hunter_Addresses",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustrialTown",
                table: "Hunter_Addresses",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInTownEnv",
                table: "Hunter_Addresses",
                type: "tinyint(1)",
                nullable: true);
        }
    }
}
