using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryJudicialActionsAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryJudicialActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    Date = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CaseStatusId = table.Column<int>(nullable: true),
                    VerdictId = table.Column<int>(nullable: true),
                    ViolationAgendaFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    JudicialActionSheetId = table.Column<string>(maxLength: 38, nullable: true),
                    VerdictFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    RelevantLegalMaterial = table.Column<string>(nullable: true),
                    JudicalCaseNumber = table.Column<string>(nullable: true),
                    CourtName = table.Column<string>(nullable: true),
                    ConsequencesAndGeneralitiesOfVerdict = table.Column<string>(nullable: true),
                    FinalSave = table.Column<bool>(nullable: false, defaultValue: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryJudicialActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActions_EnumData_CaseStatusId",
                        column: x => x.CaseStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActions_Uploads_JudicialActionSheetId",
                        column: x => x.JudicialActionSheetId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActions_Uploads_VerdictFileNameId",
                        column: x => x.VerdictFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActions_EnumData_VerdictId",
                        column: x => x.VerdictId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActions_Uploads_ViolationAgendaFileNameId",
                        column: x => x.ViolationAgendaFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryJudicialActionContractors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 300, nullable: false),
                    JudicialActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryJudicialActionContractors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryJudicialActionContractors_IndustryJudicialActions_Ju~",
                        column: x => x.JudicialActionId,
                        principalTable: "IndustryJudicialActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActionContractors_JudicialActionId",
                table: "IndustryJudicialActionContractors",
                column: "JudicialActionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_CaseStatusId",
                table: "IndustryJudicialActions",
                column: "CaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_FinalSave",
                table: "IndustryJudicialActions",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_IndustryId",
                table: "IndustryJudicialActions",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_JudicialActionSheetId",
                table: "IndustryJudicialActions",
                column: "JudicialActionSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_VerdictFileNameId",
                table: "IndustryJudicialActions",
                column: "VerdictFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_VerdictId",
                table: "IndustryJudicialActions",
                column: "VerdictId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_ViolationAgendaFileNameId",
                table: "IndustryJudicialActions",
                column: "ViolationAgendaFileNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryJudicialActionContractors");

            migrationBuilder.DropTable(
                name: "IndustryJudicialActions");
        }
    }
}
