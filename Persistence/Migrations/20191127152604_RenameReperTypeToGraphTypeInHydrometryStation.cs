using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RenameReperTypeToGraphTypeInHydrometryStation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HydrometryStations_EnumData_ReperTypeId",
                table: "HydrometryStations");

            migrationBuilder.RenameColumn(
                name: "ReperTypeId",
                table: "HydrometryStations",
                newName: "GraphTypeId");

            migrationBuilder.DropIndex(
                  name: "IX_HydrometryStations_ReperTypeId",
                  table: "HydrometryStations");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_GraphTypeId",
                table: "HydrometryStations",
                column: "GraphTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HydrometryStations_EnumData_GraphTypeId",
                table: "HydrometryStations",
                column: "GraphTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HydrometryStations_EnumData_GraphTypeId",
                table: "HydrometryStations");

            migrationBuilder.RenameColumn(
                name: "GraphTypeId",
                table: "HydrometryStations",
                newName: "ReperTypeId");

            migrationBuilder.DropIndex(
             name: "IX_HydrometryStations_GraphTypeId",
             table: "HydrometryStations");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_ReperTypeId",
                table: "HydrometryStations",
                column: "ReperTypeId");


            migrationBuilder.AddForeignKey(
                name: "FK_HydrometryStations_EnumData_ReperTypeId",
                table: "HydrometryStations",
                column: "ReperTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
