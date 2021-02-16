using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMessagesAndGroupReceivermessageAndMessageReceiverTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 38, nullable: false),
                    body = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(maxLength: 500, nullable: true),
                    SenderId = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SentDateTime = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageReceivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MessageId = table.Column<string>(maxLength: 38, nullable: false),
                    ReciverId = table.Column<int>(nullable: true),
                    ReciverGroupId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    ViewDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageReceivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageReceivers_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageReceivers_Groups_ReciverGroupId",
                        column: x => x.ReciverGroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessageReceivers_Users_ReciverId",
                        column: x => x.ReciverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "GroupReciverUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MessageReceiverId = table.Column<int>(nullable: false),
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
                name: "IX_GroupReciverUsers_MessageReceiverId",
                table: "GroupReciverUsers",
                column: "MessageReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupReciverUsers_UserId",
                table: "GroupReciverUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_Id",
                table: "MessageReceivers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_MessageId",
                table: "MessageReceivers",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_ReciverGroupId",
                table: "MessageReceivers",
                column: "ReciverGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageReceivers_ReciverId",
                table: "MessageReceivers",
                column: "ReciverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Id",
                table: "Messages",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupReciverUsers");

            migrationBuilder.DropTable(
                name: "MessageReceivers");

            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
