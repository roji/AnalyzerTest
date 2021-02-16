using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTicketAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TicketTypeId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    TicketRegion = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    DeputyId = table.Column<int>(nullable: true),
                    OfficeId = table.Column<int>(nullable: true),
                    OfficeGroupId = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    TicketDateTime = table.Column<DateTimeOffset>(nullable: false),
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
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_EnumData_DeputyId",
                        column: x => x.DeputyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_EnumData_OfficeGroupId",
                        column: x => x.OfficeGroupId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_EnumData_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_EnumData_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketReplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    IsExpert = table.Column<bool>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ReplyDateTime = table.Column<DateTimeOffset>(nullable: false),
                    TicketFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    TicketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketReplies_Uploads_TicketFileNameId",
                        column: x => x.TicketFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TicketReplies_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketReplies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    TicketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketUsers_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketReplies_TicketFileNameId",
                table: "TicketReplies",
                column: "TicketFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketReplies_TicketId",
                table: "TicketReplies",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketReplies_UserId",
                table: "TicketReplies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DeputyId",
                table: "Tickets",
                column: "DeputyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OfficeGroupId",
                table: "Tickets",
                column: "OfficeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OfficeId",
                table: "Tickets",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProvinceId",
                table: "Tickets",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StateId",
                table: "Tickets",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketTypeId",
                table: "Tickets",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketUsers_TicketId",
                table: "TicketUsers",
                column: "TicketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketUsers_UserId",
                table: "TicketUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketReplies");

            migrationBuilder.DropTable(
                name: "TicketUsers");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
