using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAssistanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assistances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Introduction = table.Column<string>(nullable: true),
                    AssistanceClassificationId = table.Column<int>(nullable: true),
                    HelpFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    FrequentlyAskedQuestions = table.Column<string>(nullable: true),
                    IdentityCardFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    ContactInformation = table.Column<string>(nullable: true),
                    SurfaceStatement = table.Column<string>(nullable: true),
                    HasIdentityNumber = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_Assistances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assistances_EnumData_AssistanceClassificationId",
                        column: x => x.AssistanceClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assistances_Uploads_HelpFileNameId",
                        column: x => x.HelpFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assistances_Uploads_IdentityCardFileNameId",
                        column: x => x.IdentityCardFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assistances_AssistanceClassificationId",
                table: "Assistances",
                column: "AssistanceClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Assistances_HelpFileNameId",
                table: "Assistances",
                column: "HelpFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Assistances_IdentityCardFileNameId",
                table: "Assistances",
                column: "IdentityCardFileNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assistances");
        }
    }
}
