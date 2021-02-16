using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIsInspectionDoneAndWhyNotDescriptionToInspectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInspectionDone",
                table: "IndustryInspections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyNotInspectionDoneDescription",
                table: "IndustryInspections",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInspectionDone",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "WhyNotInspectionDoneDescription",
                table: "IndustryInspections");
        }
    }
}
