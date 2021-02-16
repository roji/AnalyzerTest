using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToComplaintTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "AnswerDateTime",
                table: "Complaints",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "AnswerStartPendingDateTime",
                table: "Complaints",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerDateTime",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "AnswerStartPendingDateTime",
                table: "Complaints");
        }
    }
}
