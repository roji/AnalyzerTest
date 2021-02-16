using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MoveMessageStatusToMessageReceiversTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MessageReceivers");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverStatus",
                table: "MessageReceivers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderStatus",
                table: "MessageReceivers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverStatus",
                table: "MessageReceivers");

            migrationBuilder.DropColumn(
                name: "SenderStatus",
                table: "MessageReceivers");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "MessageReceivers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
