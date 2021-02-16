using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToAccountNumberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "AccountNumbers",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchCode",
                table: "AccountNumbers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "AccountNumbers",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Card",
                table: "AccountNumbers",
                maxLength: 19,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Shaba",
                table: "AccountNumbers",
                maxLength: 26,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "AccountNumbers");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "AccountNumbers");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "AccountNumbers");

            migrationBuilder.DropColumn(
                name: "Card",
                table: "AccountNumbers");

            migrationBuilder.DropColumn(
                name: "Shaba",
                table: "AccountNumbers");
        }
    }
}
