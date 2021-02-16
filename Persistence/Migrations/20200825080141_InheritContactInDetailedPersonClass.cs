using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InheritContactInDetailedPersonClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Researcher_Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Researcher_Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Researcher_Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "Researcher_Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Researcher_Addresses");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Researcher_Addresses");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Researcher_Addresses");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "Researcher_Addresses");
        }
    }
}
