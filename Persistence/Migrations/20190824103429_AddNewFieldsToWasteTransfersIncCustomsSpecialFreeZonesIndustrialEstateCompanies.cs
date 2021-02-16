using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToWasteTransfersIncCustomsSpecialFreeZonesIndustrialEstateCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomsIds",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustrialEstateCompaniesIds",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialFreeZonesIds",
                table: "WasteTransfers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomsIds",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "IndustrialEstateCompaniesIds",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "SpecialFreeZonesIds",
                table: "WasteTransfers");
        }
    }
}
