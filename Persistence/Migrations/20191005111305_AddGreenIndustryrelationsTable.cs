using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddGreenIndustryrelationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GreenIndustryRelations",
                columns: table => new
                {
                    EstablishmentGroupingId = table.Column<int>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false),
                    Score = table.Column<double>(nullable: true),
                    Ratio = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_GreenIndustryRelations", x => new { x.EstablishmentGroupingId, x.TechnologyId });
                    table.ForeignKey(
                        name: "FK_GreenIndustryRelations_EnumData_EstablishmentGroupingId",
                        column: x => x.EstablishmentGroupingId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GreenIndustryRelations_EnumData_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryRelations_EstablishmentGroupingId",
                table: "GreenIndustryRelations",
                column: "EstablishmentGroupingId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryRelations_TechnologyId",
                table: "GreenIndustryRelations",
                column: "TechnologyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GreenIndustryRelations");
        }
    }
}
