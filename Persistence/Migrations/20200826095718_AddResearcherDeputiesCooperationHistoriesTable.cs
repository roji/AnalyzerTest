using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddResearcherDeputiesCooperationHistoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResearcherDeputiesCooperationHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    DeputyId = table.Column<int>(nullable: true),
                    OfficeId = table.Column<int>(nullable: true),
                    ContractSubject = table.Column<string>(nullable: true),
                    ContractYear = table.Column<int>(nullable: false),
                    ContractRelatedIndustryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ResearcherId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ResearcherDeputiesCooperationHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearcherDeputiesCooperationHistories_EnumData_DeputyId",
                        column: x => x.DeputyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResearcherDeputiesCooperationHistories_EnumData_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResearcherDeputiesCooperationHistories_Researchers_Researche~",
                        column: x => x.ResearcherId,
                        principalTable: "Researchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResearcherDeputiesCooperationHistories_DeputyId",
                table: "ResearcherDeputiesCooperationHistories",
                column: "DeputyId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearcherDeputiesCooperationHistories_OfficeId",
                table: "ResearcherDeputiesCooperationHistories",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearcherDeputiesCooperationHistories_ResearcherId",
                table: "ResearcherDeputiesCooperationHistories",
                column: "ResearcherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearcherDeputiesCooperationHistories");
        }
    }
}
