using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryInspectionToIndustryWarningTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustryInspectionId",
                table: "IndustryWarnings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_IndustryInspectionId",
                table: "IndustryWarnings",
                column: "IndustryInspectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryWarnings_IndustryInspections_IndustryInspectionId",
                table: "IndustryWarnings",
                column: "IndustryInspectionId",
                principalTable: "IndustryInspections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryWarnings_IndustryInspections_IndustryInspectionId",
                table: "IndustryWarnings");

            migrationBuilder.DropIndex(
                name: "IX_IndustryWarnings_IndustryInspectionId",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "IndustryInspectionId",
                table: "IndustryWarnings");
        }
    }
}
