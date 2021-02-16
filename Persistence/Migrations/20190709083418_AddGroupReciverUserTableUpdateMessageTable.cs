using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddGroupReciverUserTableUpdateMessageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReciverGroupId",
                table: "Messages",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupReciverUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 38, nullable: false),
                    MessageId = table.Column<string>(maxLength: 38, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupReciverUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupReciverUsers_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupReciverUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReciverGroupId",
                table: "Messages",
                column: "ReciverGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReciverUsers_MessageId",
                table: "GroupReciverUsers",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReciverUsers_UserId",
                table: "GroupReciverUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_ReciverGroupId",
                table: "Messages",
                column: "ReciverGroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_ReciverGroupId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "GroupReciverUsers");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReciverGroupId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReciverGroupId",
                table: "Messages");
        }
    }
}
