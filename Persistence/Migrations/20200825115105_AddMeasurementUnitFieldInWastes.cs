using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMeasurementUnitFieldInWastes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResearcherForeignLanguages_EnumData_ForeignLanguageId",
                table: "ResearcherForeignLanguages");

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnit",
                table: "Wastes",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearcherForeignLanguages_EnumData_ForeignLanguageId",
                table: "ResearcherForeignLanguages",
                column: "ForeignLanguageId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResearcherForeignLanguages_EnumData_ForeignLanguageId",
                table: "ResearcherForeignLanguages");

            migrationBuilder.DropColumn(
                name: "MeasurementUnit",
                table: "Wastes");

            migrationBuilder.AddForeignKey(
                name: "FK_ResearcherForeignLanguages_EnumData_ForeignLanguageId",
                table: "ResearcherForeignLanguages",
                column: "ForeignLanguageId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
