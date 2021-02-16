using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveGroupReceiversTableAndGroupReceiverIdFieldInMessageReceiversTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageReceivers_Groups_ReciverGroupId",
                table: "MessageReceivers");

            migrationBuilder.DropTable(
                name: "GroupReciverUsers");

            migrationBuilder.DropIndex(
                name: "IX_MessageReceivers_ReciverGroupId",
                table: "MessageReceivers");

            migrationBuilder.DropColumn(
                name: "ReciverGroupId",
                table: "MessageReceivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReciverGroupId",
                table: "MessageReceivers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupReciverUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    MessageReceiverId = table.Column<int>(nullable: false),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupReciverUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupReciverUsers_MessageReceivers_MessageReceiverId",
                        column: x => x.MessageReceiverId,
                        principalTable: "MessageReceivers",
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
                name: "IX_MessageReceivers_ReciverGroupId",
                table: "MessageReceivers",
                column: "ReciverGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReciverUsers_MessageReceiverId",
                table: "GroupReciverUsers",
                column: "MessageReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReciverUsers_UserId",
                table: "GroupReciverUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageReceivers_Groups_ReciverGroupId",
                table: "MessageReceivers",
                column: "ReciverGroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
