using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddSelectedInspectionDateFieldToIndustryEstablishment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SelectedInspectionDateId",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_SelectedInspectionDateId",
                table: "IndustryEstablishments",
                column: "SelectedInspectionDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments",
                column: "SelectedInspectionDateId",
                principalTable: "IndustryEstablishmentInspectionDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_SelectedInspectionDateId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "SelectedInspectionDateId",
                table: "IndustryEstablishments");
        }
    }
}
