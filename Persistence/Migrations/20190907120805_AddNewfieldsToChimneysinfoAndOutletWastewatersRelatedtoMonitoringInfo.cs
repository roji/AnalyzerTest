using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewfieldsToChimneysinfoAndOutletWastewatersRelatedtoMonitoringInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasOutletSludge",
                table: "OutletWastewaters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutletDescription",
                table: "OutletWastewaters",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PossibleToTakeSamplingFromOutletSludge",
                table: "OutletWastewaters",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Diameter",
                table: "ChimneysInfo",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Elevation",
                table: "ChimneysInfo",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasSamplingGate",
                table: "ChimneysInfo",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStandardConditionsObserved",
                table: "ChimneysInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasOutletSludge",
                table: "OutletWastewaters");

            migrationBuilder.DropColumn(
                name: "OutletDescription",
                table: "OutletWastewaters");

            migrationBuilder.DropColumn(
                name: "PossibleToTakeSamplingFromOutletSludge",
                table: "OutletWastewaters");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "ChimneysInfo");

            migrationBuilder.DropColumn(
                name: "Elevation",
                table: "ChimneysInfo");

            migrationBuilder.DropColumn(
                name: "HasSamplingGate",
                table: "ChimneysInfo");

            migrationBuilder.DropColumn(
                name: "IsStandardConditionsObserved",
                table: "ChimneysInfo");
        }
    }
}
