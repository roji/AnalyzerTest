using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLabRelationTowasteTransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabId",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_LabId",
                table: "WasteTransfers",
                column: "LabId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransfers_Labs_LabId",
                table: "WasteTransfers",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransfers_Labs_LabId",
                table: "WasteTransfers");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransfers_LabId",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "LabId",
                table: "WasteTransfers");
        }
    }
}
