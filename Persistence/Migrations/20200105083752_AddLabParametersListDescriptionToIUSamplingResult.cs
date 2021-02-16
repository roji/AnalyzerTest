using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLabParametersListDescriptionToIUSamplingResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParametersListDescription",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParametersListDescription",
                table: "IndustrialUnitsSamplingResults");
        }
    }
}
