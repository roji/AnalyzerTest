using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveGroupReceiversTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageReceivers_Groups_ReceiverGroupId",
                table: "MessageReceivers");

            migrationBuilder.DropTable(
                name: "GroupReceiverUsers");

            migrationBuilder.DropIndex(
                name: "IX_MessageReceivers_ReceiverGroupId",
                table: "MessageReceivers");

            migrationBuilder.DropColumn(
                name: "ReceiverGroupId",
                table: "MessageReceivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverGroupId",
                table: "MessageReceivers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupReceiverUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MessageReceiverId = table.Column<long>(type: "bigint", nullable: false),
                    ReceiverStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "longtext", nullable: true),
                    ViewDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupReceiverUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupReceiverUsers_MessageReceivers_MessageReceiverId",
                        column: x => x.MessageReceiverId,
                        principalTable: "MessageReceivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupReceiverUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_ReceiverGroupId",
                table: "MessageReceivers",
                column: "ReceiverGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReceiverUsers_MessageReceiverId",
                table: "GroupReceiverUsers",
                column: "MessageReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReceiverUsers_UserId",
                table: "GroupReceiverUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageReceivers_Groups_ReceiverGroupId",
                table: "MessageReceivers",
                column: "ReceiverGroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
