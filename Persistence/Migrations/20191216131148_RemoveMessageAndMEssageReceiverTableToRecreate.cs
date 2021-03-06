﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveMessageAndMEssageReceiverTableToRecreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageReceivers");

            migrationBuilder.DropTable(
                name: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 38, nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    SenderId = table.Column<int>(nullable: false),
                    SentDateTime = table.Column<DateTimeOffset>(nullable: false),
                    Subject = table.Column<string>(maxLength: 500, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    body = table.Column<string>(nullable: true)
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
                    ReceiverStatus = table.Column<int>(nullable: false),
                    ReciverId = table.Column<int>(nullable: true),
                    SenderStatus = table.Column<int>(nullable: false),
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
                        name: "FK_MessageReceivers_Users_ReciverId",
                        column: x => x.ReciverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

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
    }
}
