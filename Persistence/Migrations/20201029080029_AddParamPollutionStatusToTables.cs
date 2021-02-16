using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddParamPollutionStatusToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "WastewaterParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "WasteParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SoundAndWavesParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ChimneyParametersResults",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AmbientAirParametersResults",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AmbientAirParametersResults");
        }
    }
}
