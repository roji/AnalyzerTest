using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddGreenIndustryAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GreenIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    HasRequestForGreenIndustry = table.Column<bool>(nullable: true),
                    HasPollutionInLastYear = table.Column<bool>(nullable: true),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    FinalSave = table.Column<bool>(nullable: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
                    ShowingMarkForIndustryDate = table.Column<int>(nullable: true),
                    GreenIndustryStatus = table.Column<int>(nullable: false),
                    PayBillFileName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_GreenIndustries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GreenIndustries_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GreenIndustryDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GreenIndustryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    SystemComment = table.Column<string>(nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(nullable: false),
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
                    table.PrimaryKey("PK_GreenIndustryDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GreenIndustryDescriptions_GreenIndustries_GreenIndustryId",
                        column: x => x.GreenIndustryId,
                        principalTable: "GreenIndustries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GreenIndustryDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GreenIndustryStrategies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GreenIndustryId = table.Column<int>(nullable: false),
                    IndicatorId = table.Column<int>(nullable: false),
                    CriterionId = table.Column<int>(nullable: false),
                    UnderCriteriaId = table.Column<int>(nullable: false),
                    StrategyId = table.Column<int>(nullable: false),
                    StartingYear = table.Column<int>(nullable: true),
                    OperationYear = table.Column<int>(nullable: true),
                    Cost = table.Column<double>(nullable: true),
                    ExecutionOperationTechnicalDetails = table.Column<string>(nullable: true),
                    PreviousAnalysisResult = table.Column<string>(nullable: true),
                    CurrentAnalysisResult = table.Column<string>(nullable: true),
                    DocumentFileName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_GreenIndustryStrategies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GreenIndustryStrategies_EnumData_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GreenIndustryStrategies_GreenIndustries_GreenIndustryId",
                        column: x => x.GreenIndustryId,
                        principalTable: "GreenIndustries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GreenIndustryStrategies_EnumData_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GreenIndustryStrategies_EnumData_StrategyId",
                        column: x => x.StrategyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GreenIndustryStrategies_EnumData_UnderCriteriaId",
                        column: x => x.UnderCriteriaId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustries_IndustryId",
                table: "GreenIndustries",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryDescriptions_GreenIndustryId",
                table: "GreenIndustryDescriptions",
                column: "GreenIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryDescriptions_UserId",
                table: "GreenIndustryDescriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_CriterionId",
                table: "GreenIndustryStrategies",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_GreenIndustryId",
                table: "GreenIndustryStrategies",
                column: "GreenIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_IndicatorId",
                table: "GreenIndustryStrategies",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_StrategyId",
                table: "GreenIndustryStrategies",
                column: "StrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_UnderCriteriaId",
                table: "GreenIndustryStrategies",
                column: "UnderCriteriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GreenIndustryDescriptions");

            migrationBuilder.DropTable(
                name: "GreenIndustryStrategies");

            migrationBuilder.DropTable(
                name: "GreenIndustries");
        }
    }
}
