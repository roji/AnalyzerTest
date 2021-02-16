using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRequestedFieldsToMunicaplityWasteSpecialtyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustrialWasteDailyCollection",
                table: "MunicipalityWasteSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WasteTransportationMachineryQuantity",
                table: "MunicipalityWasteSpecialtyInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndustrialWasteDailyCollection",
                table: "MunicipalityWasteSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "WasteTransportationMachineryQuantity",
                table: "MunicipalityWasteSpecialtyInfos");
        }
    }
}
