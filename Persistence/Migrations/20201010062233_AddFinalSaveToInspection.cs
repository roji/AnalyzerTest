using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFinalSaveToInspection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "IndustryInspections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "IndustryInspections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_FinalSave",
                table: "IndustryInspections",
                column: "FinalSave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IndustryInspections_FinalSave",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "IndustryInspections");
        }
    }
}
