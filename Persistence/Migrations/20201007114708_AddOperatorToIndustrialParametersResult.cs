using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddOperatorToIndustrialParametersResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Operator",
                table: "WastewaterParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Operator",
                table: "WasteParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Operator",
                table: "SoundAndWavesParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Operator",
                table: "ChimneyParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Operator",
                table: "AmbientAirParametersResults",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operator",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "AmbientAirParametersResults");
        }
    }
}
