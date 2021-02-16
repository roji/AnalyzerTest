using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddUsernameAndUserIdtoWasteDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WasteTransfersDescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "WasteTransfersDescriptions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfersDescriptions_UserId",
                table: "WasteTransfersDescriptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransfersDescriptions_Users_UserId",
                table: "WasteTransfersDescriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransfersDescriptions_Users_UserId",
                table: "WasteTransfersDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransfersDescriptions_UserId",
                table: "WasteTransfersDescriptions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WasteTransfersDescriptions");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "WasteTransfersDescriptions");
        }
    }
}
