using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteDamSpecialtyInfoAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WasteDamSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteDamTypeId = table.Column<int>(nullable: false),
                    RelatedIndustryId = table.Column<int>(nullable: true),
                    DistanceToRelatedIndustry = table.Column<double>(nullable: true),
                    RelatedMineId = table.Column<int>(nullable: true),
                    DistanceToRelatedMine = table.Column<double>(nullable: true),
                    WasteMaterialQuantity = table.Column<double>(nullable: true),
                    WasteMaterialQuality = table.Column<string>(nullable: true),
                    WasteMaterialHumidity = table.Column<double>(nullable: true),
                    HasStabilitySurvey = table.Column<bool>(nullable: true),
                    StabilitySurveryDescription = table.Column<string>(nullable: true),
                    WasteDamWaterDepth = table.Column<double>(nullable: true),
                    WasteDamStorageSize = table.Column<double>(nullable: true),
                    WasteDamStorageSizeDuration = table.Column<int>(nullable: true),
                    WasteDamCurrentStorageSize = table.Column<double>(nullable: true),
                    WasteDamCurrentStorageSizeDate = table.Column<int>(nullable: true),
                    EarthquakeIssuesHaveBeenAddressed = table.Column<bool>(nullable: true),
                    EarthquakeIssuesDescription = table.Column<string>(nullable: true),
                    TopPlansHaveBeenAddressed = table.Column<bool>(nullable: true),
                    TopPlansDescription = table.Column<string>(nullable: true),
                    HasTopographicSurvey = table.Column<bool>(nullable: true),
                    HasGeologicalSurvey = table.Column<bool>(nullable: true),
                    HasChemicalCompositionSurvey = table.Column<bool>(nullable: true),
                    HasHydrogeologySurvey = table.Column<bool>(nullable: true),
                    HasSurfaceWaterSurvey = table.Column<bool>(nullable: true),
                    HasEarthquakeRelatedDataSurvey = table.Column<bool>(nullable: true),
                    HasDistanceToSenstiveReceiversSurvey = table.Column<bool>(nullable: true),
                    HasDistanceToMineOperatingSurvey = table.Column<bool>(nullable: true),
                    HasMineAdjacentInfrastructureSurvey = table.Column<bool>(nullable: true),
                    HasTailingSurvey = table.Column<bool>(nullable: true),
                    HasWaterManagementSurvey = table.Column<bool>(nullable: true),
                    HasWorkEffectsSurvey = table.Column<bool>(nullable: true),
                    HasMineralResourcesPotentialSurvey = table.Column<bool>(nullable: true),
                    HasPlannedInnovationRevenuesSurvey = table.Column<bool>(nullable: true),
                    ChemicalAnalysisFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    StabilitySurveryFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    EnvironmentEffectsFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteDamSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_Uploads_ChemicalAnalysisFileNameId",
                        column: x => x.ChemicalAnalysisFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_Uploads_EnvironmentEffectsFileNameId",
                        column: x => x.EnvironmentEffectsFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_Industries_RelatedIndustryId",
                        column: x => x.RelatedIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_Industries_RelatedMineId",
                        column: x => x.RelatedMineId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_Uploads_StabilitySurveryFileNameId",
                        column: x => x.StabilitySurveryFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfos_EnumData_WasteDamTypeId",
                        column: x => x.WasteDamTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WasteDamSpecialtyInfoProblems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CheckDate = table.Column<int>(nullable: true),
                    WasteDamSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteDamSpecialtyInfoProblems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfoProblems_WasteDamSpecialtyInfos_WasteDa~",
                        column: x => x.WasteDamSpecialtyInfoId,
                        principalTable: "WasteDamSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteDamSpecialtyInfoWaterQualityMonitoringStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WaterQualityMonitoringStationId = table.Column<int>(nullable: false),
                    WasteDamSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteDamSpecialtyInfoWaterQualityMonitoringStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfoWaterQualityMonitoringStations_WasteDam~",
                        column: x => x.WasteDamSpecialtyInfoId,
                        principalTable: "WasteDamSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteDamSpecialtyInfoWaterQualityMonitoringStations_WaterQua~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfoProblems_WasteDamSpecialtyInfoId",
                table: "WasteDamSpecialtyInfoProblems",
                column: "WasteDamSpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_ChemicalAnalysisFileNameId",
                table: "WasteDamSpecialtyInfos",
                column: "ChemicalAnalysisFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_EnvironmentEffectsFileNameId",
                table: "WasteDamSpecialtyInfos",
                column: "EnvironmentEffectsFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_IndustryId",
                table: "WasteDamSpecialtyInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_RelatedIndustryId",
                table: "WasteDamSpecialtyInfos",
                column: "RelatedIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_RelatedMineId",
                table: "WasteDamSpecialtyInfos",
                column: "RelatedMineId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_StabilitySurveryFileNameId",
                table: "WasteDamSpecialtyInfos",
                column: "StabilitySurveryFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfos_WasteDamTypeId",
                table: "WasteDamSpecialtyInfos",
                column: "WasteDamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfoWaterQualityMonitoringStations_WasteDam~",
                table: "WasteDamSpecialtyInfoWaterQualityMonitoringStations",
                column: "WasteDamSpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteDamSpecialtyInfoWaterQualityMonitoringStations_WaterQua~",
                table: "WasteDamSpecialtyInfoWaterQualityMonitoringStations",
                column: "WaterQualityMonitoringStationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteDamSpecialtyInfoProblems");

            migrationBuilder.DropTable(
                name: "WasteDamSpecialtyInfoWaterQualityMonitoringStations");

            migrationBuilder.DropTable(
                name: "WasteDamSpecialtyInfos");
        }
    }
}
