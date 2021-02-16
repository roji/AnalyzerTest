using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteTransferPeriodAndTransportationVehicleToWasteTransferTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransportationVehicle",
                table: "WasteTransfers",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WasteTransferPeriodId",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_WasteTransferPeriodId",
                table: "WasteTransfers",
                column: "WasteTransferPeriodId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransfers_EnumData_WasteTransferPeriodId",
                table: "WasteTransfers",
                column: "WasteTransferPeriodId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransfers_EnumData_WasteTransferPeriodId",
                table: "WasteTransfers");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransfers_WasteTransferPeriodId",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "TransportationVehicle",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "WasteTransferPeriodId",
                table: "WasteTransfers");
        }
    }
}
