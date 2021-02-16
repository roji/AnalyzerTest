using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixSpellOfAnswerFieldInComplaint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anwser",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "AnwserSatisfaction",
                table: "Complaints");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Complaints",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AnswerSatisfaction",
                table: "Complaints",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "AnswerSatisfaction",
                table: "Complaints");

            migrationBuilder.AddColumn<string>(
                name: "Anwser",
                table: "Complaints",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AnwserSatisfaction",
                table: "Complaints",
                type: "tinyint(1)",
                nullable: true);
        }
    }
}
