using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixRelationInAncientMuseumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AncientMuseums_EnumData_AncientFamilyId1",
                table: "AncientMuseums");

            migrationBuilder.DropIndex(
                name: "IX_AncientMuseums_AncientFamilyId1",
                table: "AncientMuseums");

            migrationBuilder.DropColumn(
                name: "AncientFamilyId1",
                table: "AncientMuseums");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientSubFamilyId",
                table: "AncientMuseums",
                column: "AncientSubFamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AncientMuseums_EnumData_AncientSubFamilyId",
                table: "AncientMuseums",
                column: "AncientSubFamilyId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AncientMuseums_EnumData_AncientSubFamilyId",
                table: "AncientMuseums");

            migrationBuilder.DropIndex(
                name: "IX_AncientMuseums_AncientSubFamilyId",
                table: "AncientMuseums");

            migrationBuilder.AddColumn<int>(
                name: "AncientFamilyId1",
                table: "AncientMuseums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientFamilyId1",
                table: "AncientMuseums",
                column: "AncientFamilyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AncientMuseums_EnumData_AncientFamilyId1",
                table: "AncientMuseums",
                column: "AncientFamilyId1",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
