using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTwoNewFieldsToWasteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProduceFrequencyId",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProducedWasteLocationId",
                table: "Wastes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_ProduceFrequencyId",
                table: "Wastes",
                column: "ProduceFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_ProducedWasteLocationId",
                table: "Wastes",
                column: "ProducedWasteLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_ProduceFrequencyId",
                table: "Wastes",
                column: "ProduceFrequencyId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_ProducedWasteLocationId",
                table: "Wastes",
                column: "ProducedWasteLocationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_ProduceFrequencyId",
                table: "Wastes");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_ProducedWasteLocationId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_ProduceFrequencyId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_ProducedWasteLocationId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "ProduceFrequencyId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "ProducedWasteLocationId",
                table: "Wastes");
        }
    }
}
