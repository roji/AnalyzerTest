using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLabSupervisionAndRelatedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabSupervisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringInternalSection = table.Column<string>(nullable: true),
                    MonitoringExternalSection = table.Column<string>(nullable: true),
                    MonitoringDate = table.Column<int>(nullable: false),
                    MonitoringOfficeExpertsEnteringHour = table.Column<string>(nullable: true),
                    LabExpertsEnteringHour = table.Column<string>(nullable: true),
                    ExpertsCoordinationEnteringDescription = table.Column<string>(nullable: true),
                    LabExpertNamesAndAuthenticationMethod = table.Column<string>(nullable: true),
                    AnalyzerDeviceModel = table.Column<string>(nullable: true),
                    AnalyzerDeviceSerialNumber = table.Column<string>(nullable: true),
                    IsAnalyzerDeviceRegisteredInProfile = table.Column<bool>(nullable: true),
                    IsAnalyzerDeviceCalibrationLicenseVerified = table.Column<bool>(nullable: true),
                    AnalyzerDeviceCalibrationLicenseVerifiedDescription = table.Column<string>(nullable: true),
                    IsSensorAndExpirationDateVerified = table.Column<bool>(nullable: true),
                    SensorAndExpirationDateVerifiedDescription = table.Column<string>(nullable: true),
                    SamplingStartingHour = table.Column<string>(nullable: true),
                    SamplingMethodDefinition = table.Column<string>(nullable: true),
                    SamplingLocation = table.Column<string>(nullable: true),
                    SamplingPointsDescription = table.Column<string>(nullable: true),
                    FetchDataRegisteringMethod = table.Column<string>(nullable: true),
                    DoesLabExpertHasRequiredSkills = table.Column<bool>(nullable: true),
                    LabExpertHasRequiredSkillsDescription = table.Column<string>(nullable: true),
                    DoesSamplingFromRightPlace = table.Column<bool>(nullable: true),
                    SamplingFromRightPlaceDescription = table.Column<string>(nullable: true),
                    DoesRealSamplingFromPlace = table.Column<bool>(nullable: true),
                    RealSamplingFromPlaceDescription = table.Column<string>(nullable: true),
                    IsSampleTransferConditionsObserved = table.Column<bool>(nullable: true),
                    SampleTransferConditionsObservedDescription = table.Column<string>(nullable: true),
                    SamplingParameters = table.Column<string>(nullable: true),
                    SamplingEndingHour = table.Column<string>(nullable: true),
                    DocumentFileDescription = table.Column<string>(nullable: true),
                    LabExpertsLeavingHour = table.Column<string>(nullable: true),
                    MonitoringOfficeExpertsLeavingHour = table.Column<string>(nullable: true),
                    IndustrialUnitsSamplingResultId = table.Column<int>(nullable: false),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    IndustryReferralTimeActivityMethodId = table.Column<int>(nullable: true),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_LabSupervisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabSupervisions_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabSupervisions_IndustrialUnitsSamplingResults_IndustrialUni~",
                        column: x => x.IndustrialUnitsSamplingResultId,
                        principalTable: "IndustrialUnitsSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabSupervisions_EnumData_IndustryReferralTimeActivityMethodId",
                        column: x => x.IndustryReferralTimeActivityMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabSupervisions_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabSupervisionSupervisingExperts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 256, nullable: false),
                    Rank = table.Column<string>(maxLength: 256, nullable: false),
                    LabSupervisionId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_LabSupervisionSupervisingExperts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabSupervisionSupervisingExperts_LabSupervisions_LabSupervis~",
                        column: x => x.LabSupervisionId,
                        principalTable: "LabSupervisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabSupervisions_DocumentFileNameId",
                table: "LabSupervisions",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LabSupervisions_IndustrialUnitsSamplingResultId",
                table: "LabSupervisions",
                column: "IndustrialUnitsSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_LabSupervisions_IndustryReferralTimeActivityMethodId",
                table: "LabSupervisions",
                column: "IndustryReferralTimeActivityMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_LabSupervisions_LabId",
                table: "LabSupervisions",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_LabSupervisionSupervisingExperts_LabSupervisionId",
                table: "LabSupervisionSupervisingExperts",
                column: "LabSupervisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabSupervisionSupervisingExperts");

            migrationBuilder.DropTable(
                name: "LabSupervisions");
        }
    }
}
