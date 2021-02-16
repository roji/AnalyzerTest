using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentInspectionInfoAndSubTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(maxLength: 10, nullable: true),
                    ExpertTheory = table.Column<string>(nullable: true),
                    IndustryEstablishmentId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentInspectionInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentInspectionInfos_IndustryEstablishments_~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionInfoVisitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 350, nullable: false),
                    Rank = table.Column<string>(nullable: true),
                    IndustryEstablishmentInspectionInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentInspectionInfoVisitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentInspectionInfoVisitors_IndustryEstablis~",
                        column: x => x.IndustryEstablishmentInspectionInfoId,
                        principalTable: "IndustryEstablishmentInspectionInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionInfos_IndustryEstablishmentId",
                table: "IndustryEstablishmentInspectionInfos",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionInfoVisitors_IndustryEstablis~",
                table: "IndustryEstablishmentInspectionInfoVisitors",
                column: "IndustryEstablishmentInspectionInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionInfoVisitors");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionInfos");
        }
    }
}
