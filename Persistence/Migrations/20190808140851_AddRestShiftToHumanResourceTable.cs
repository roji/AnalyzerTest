using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRestShiftToHumanResourceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasRestShift",
                table: "HumanResources",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RestShiftFromHour",
                table: "HumanResources",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestShiftPersonnelQuantity",
                table: "HumanResources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RestShiftToHour",
                table: "HumanResources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasRestShift",
                table: "HumanResources");

            migrationBuilder.DropColumn(
                name: "RestShiftFromHour",
                table: "HumanResources");

            migrationBuilder.DropColumn(
                name: "RestShiftPersonnelQuantity",
                table: "HumanResources");

            migrationBuilder.DropColumn(
                name: "RestShiftToHour",
                table: "HumanResources");
        }
    }
}
