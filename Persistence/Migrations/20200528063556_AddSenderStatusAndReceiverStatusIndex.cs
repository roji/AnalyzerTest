using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddSenderStatusAndReceiverStatusIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_ReceiverStatus",
                table: "MessageReceivers",
                column: "ReceiverStatus");

            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_SenderStatus",
                table: "MessageReceivers",
                column: "SenderStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MessageReceivers_ReceiverStatus",
                table: "MessageReceivers");

            migrationBuilder.DropIndex(
                name: "IX_MessageReceivers_SenderStatus",
                table: "MessageReceivers");
        }
    }
}
