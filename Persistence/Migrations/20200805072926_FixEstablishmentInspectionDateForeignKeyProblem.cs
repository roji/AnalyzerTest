using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixEstablishmentInspectionDateForeignKeyProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments",
                column: "SelectedInspectionDateId",
                principalTable: "IndustryEstablishmentInspectionDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments",
                column: "SelectedInspectionDateId",
                principalTable: "IndustryEstablishmentInspectionDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
