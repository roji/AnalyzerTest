using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveOperationLicensePhotoNameFromWastemanagementunitinfosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationLicensePhotoName",
                table: "WasteManagementUnitsInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OperationLicensePhotoName",
                table: "WasteManagementUnitsInfos",
                nullable: true);
        }
    }
}
