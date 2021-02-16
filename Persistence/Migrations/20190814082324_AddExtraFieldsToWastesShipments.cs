using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddExtraFieldsToWastesShipments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SealValidation",
                table: "WastesShipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisionOverDischargeFileName",
                table: "WastesShipments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SealValidation",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "SupervisionOverDischargeFileName",
                table: "WastesShipments");
        }
    }
}
