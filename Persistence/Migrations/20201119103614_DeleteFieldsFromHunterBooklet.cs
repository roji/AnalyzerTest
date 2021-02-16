using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DeleteFieldsFromHunterBooklet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHunterTrained",
                table: "HunterBooklets");

            migrationBuilder.DropColumn(
                name: "IsProfileComplete",
                table: "HunterBooklets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHunterTrained",
                table: "HunterBooklets",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsProfileComplete",
                table: "HunterBooklets",
                type: "tinyint(1)",
                nullable: true);
        }
    }
}
