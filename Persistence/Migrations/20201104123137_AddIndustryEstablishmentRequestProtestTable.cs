using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentRequestProtestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentRequestProtests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SecretariatRegisterDate = table.Column<int>(nullable: false),
                    ProtestLetterFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    AgendaFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    CommissionDate = table.Column<int>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    CommissionResult = table.Column<bool>(nullable: true),
                    IndustryEstablishmentRequestId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentRequestProtests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentRequestProtests_Uploads_AgendaFileNameId",
                        column: x => x.AgendaFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentRequestProtests_IndustryEstablishmentRe~",
                        column: x => x.IndustryEstablishmentRequestId,
                        principalTable: "IndustryEstablishmentRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentRequestProtests_Uploads_ProtestLetterFi~",
                        column: x => x.ProtestLetterFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentRequestProtests_AgendaFileNameId",
                table: "IndustryEstablishmentRequestProtests",
                column: "AgendaFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentRequestProtests_IndustryEstablishmentRe~",
                table: "IndustryEstablishmentRequestProtests",
                column: "IndustryEstablishmentRequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentRequestProtests_ProtestLetterFileNameId",
                table: "IndustryEstablishmentRequestProtests",
                column: "ProtestLetterFileNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEstablishmentRequestProtests");
        }
    }
}
