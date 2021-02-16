using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFinalSaveFieldToLabInspectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "LabInspections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "LabInspections",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "LabInspections");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "LabInspections");
        }
    }
}
