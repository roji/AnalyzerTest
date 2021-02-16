using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateWastemanagementUnitsInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OperationalProcessIds",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemainedWasteManagementMethod",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UomDescription",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UsingOtherMaterial",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WasteRemainAfterOperationalProccess",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteResultAfterOperationalProccess",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkingMethod",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WraopDescription",
                table: "WasteManagementUnitsDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationalProcessIds",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "RemainedWasteManagementMethod",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "UomDescription",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "UsingOtherMaterial",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "WasteRemainAfterOperationalProccess",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "WasteResultAfterOperationalProccess",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "WorkingMethod",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "WraopDescription",
                table: "WasteManagementUnitsDetails");
        }
    }
}
