using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFinalSaveForLabSupervision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "LabSupervisions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "LabSupervisions",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FinalSave",
                table: "LabInspections",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.CreateIndex(
                name: "IX_LabSupervisions_FinalSave",
                table: "LabSupervisions",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_LabInspections_FinalSave",
                table: "LabInspections",
                column: "FinalSave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LabSupervisions_FinalSave",
                table: "LabSupervisions");

            migrationBuilder.DropIndex(
                name: "IX_LabInspections_FinalSave",
                table: "LabInspections");

            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "LabSupervisions");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "LabSupervisions");

            migrationBuilder.AlterColumn<bool>(
                name: "FinalSave",
                table: "LabInspections",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);
        }
    }
}
