using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryWarningFinalSaveField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "IndustryWarnings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "IndustryWarnings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_FinalSave",
                table: "IndustryWarnings",
                column: "FinalSave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IndustryWarnings_FinalSave",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "IndustryWarnings");
        }
    }
}
