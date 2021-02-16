using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class removeFinalSaveFromGreenIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "GreenIndustries");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "GreenIndustries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "GreenIndustries",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "GreenIndustries",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
