using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHospitalSamplingResultTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalSamplingResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrganizationRepresentativeAttendance = table.Column<bool>(nullable: true),
                    DepartmentLetterNumber = table.Column<int>(nullable: true),
                    DepartmentLetterDate = table.Column<int>(nullable: true),
                    MonitoringDate = table.Column<int>(nullable: true),
                    MonitoringHour = table.Column<string>(nullable: true),
                    IsMonitoringDone = table.Column<bool>(nullable: true),
                    MonitoringCancelingCause = table.Column<string>(nullable: true),
                    DepartmentAlternativeLetterNumber = table.Column<int>(nullable: true),
                    DepartmentAlternativeLetterDate = table.Column<int>(nullable: true),
                    MonitoringAlternativeDate = table.Column<int>(nullable: true),
                    MonitoringAlternativeHour = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExperimentReason = table.Column<int>(nullable: false),
                    ExperimentSubject = table.Column<string>(nullable: true),
                    ExperimentReasonDescription = table.Column<string>(nullable: true),
                    RialVolume = table.Column<long>(nullable: true),
                    HospitalContractFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    OrganizationRepresentativeAttendanceFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    MonitoringYear = table.Column<int>(nullable: true),
                    MonitoringPeriodId = table.Column<int>(nullable: true),
                    LabManagerVerifierId = table.Column<int>(nullable: false),
                    SamplingExpertsDescription = table.Column<string>(nullable: true),
                    HasPollution = table.Column<bool>(nullable: true),
                    HasWastePollution = table.Column<bool>(nullable: true),
                    HasDisinfectionDevicePollution = table.Column<bool>(nullable: true),
                    PollutionDescription = table.Column<string>(nullable: true),
                    FinalSave = table.Column<bool>(nullable: false, defaultValue: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
                    SamplingAnnounceDate = table.Column<DateTimeOffset>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    LabId = table.Column<int>(nullable: false),
                    IsEliminationHappenInHospital = table.Column<bool>(nullable: true),
                    EliminateOtherHospitalsWaste = table.Column<bool>(nullable: true),
                    IsMonitoringCenterSite = table.Column<bool>(nullable: true),
                    IsDevicesResultsAcceptable = table.Column<bool>(nullable: true),
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
                    table.PrimaryKey("PK_HospitalSamplingResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_Uploads_HospitalContractFileNameId",
                        column: x => x.HospitalContractFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_Personnels_LabManagerVerifierId",
                        column: x => x.LabManagerVerifierId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_EnumData_MonitoringPeriodId",
                        column: x => x.MonitoringPeriodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_Uploads_OrganizationRepresentativeAt~",
                        column: x => x.OrganizationRepresentativeAttendanceFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalDisinfectionDeviceResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceType = table.Column<int>(nullable: false),
                    PreVacuumAutoClaveBiologicalIndex = table.Column<bool>(nullable: true),
                    PreVacuumAutoClaveBowieDickChemicalIndex = table.Column<bool>(nullable: true),
                    PreVacuumAutoClaveClassFiveSixChemicalIndex = table.Column<bool>(nullable: true),
                    PreVacuumAutoClaveGuidanceMonitoringCondition = table.Column<bool>(nullable: true),
                    GravityAutoClaveGuidanceMonitoringCondition = table.Column<bool>(nullable: true),
                    GravityAutoClaveBiologicalIndex = table.Column<bool>(nullable: true),
                    GravityAutoClaveClassFiveSixChemicalIndex = table.Column<bool>(nullable: true),
                    HydroAutoClaveBiologicalIndex = table.Column<bool>(nullable: true),
                    DryHeatBiologicalIndex = table.Column<bool>(nullable: true),
                    IsAcceptable = table.Column<bool>(nullable: true),
                    HospitalSamplingResultId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HospitalDisinfectionDeviceResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalDisinfectionDeviceResults_HospitalSamplingResults_Ho~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalTesterPersonnels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonnelId = table.Column<int>(nullable: false),
                    HospitalSamplingResultId = table.Column<int>(nullable: false),
                    PersonnelType = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HospitalTesterPersonnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalTesterPersonnels_HospitalSamplingResults_HospitalSam~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalTesterPersonnels_Personnels_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalUsingFacilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HospitalSamplingResultId = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
                    UsingFacilitiesType = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HospitalUsingFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalUsingFacilities_HospitalSamplingResults_HospitalSamp~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalUsingFacilities_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalGuidanceMonitoringConditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisinfectionDeviceResultId = table.Column<int>(nullable: false),
                    GuidanceMonitoringConditionId = table.Column<int>(nullable: false),
                    AutoClaveType = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HospitalGuidanceMonitoringConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalGuidanceMonitoringConditions_HospitalDisinfectionDev~",
                        column: x => x.DisinfectionDeviceResultId,
                        principalTable: "HospitalDisinfectionDeviceResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalGuidanceMonitoringConditions_EnumData_GuidanceMonito~",
                        column: x => x.GuidanceMonitoringConditionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalDisinfectionDeviceResults_HospitalSamplingResultId",
                table: "HospitalDisinfectionDeviceResults",
                column: "HospitalSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalDisinfectionDeviceResults_IsAcceptable",
                table: "HospitalDisinfectionDeviceResults",
                column: "IsAcceptable");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalGuidanceMonitoringConditions_DisinfectionDeviceResul~",
                table: "HospitalGuidanceMonitoringConditions",
                column: "DisinfectionDeviceResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalGuidanceMonitoringConditions_GuidanceMonitoringCondi~",
                table: "HospitalGuidanceMonitoringConditions",
                column: "GuidanceMonitoringConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_FinalSave",
                table: "HospitalSamplingResults",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_HospitalContractFileNameId",
                table: "HospitalSamplingResults",
                column: "HospitalContractFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_IndustryId",
                table: "HospitalSamplingResults",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_IsDevicesResultsAcceptable",
                table: "HospitalSamplingResults",
                column: "IsDevicesResultsAcceptable");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_LabId",
                table: "HospitalSamplingResults",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_LabManagerVerifierId",
                table: "HospitalSamplingResults",
                column: "LabManagerVerifierId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_MonitoringPeriodId",
                table: "HospitalSamplingResults",
                column: "MonitoringPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_OrganizationRepresentativeAttendance~",
                table: "HospitalSamplingResults",
                column: "OrganizationRepresentativeAttendanceFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalTesterPersonnels_HospitalSamplingResultId",
                table: "HospitalTesterPersonnels",
                column: "HospitalSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalTesterPersonnels_PersonnelId",
                table: "HospitalTesterPersonnels",
                column: "PersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingFacilities_HospitalSamplingResultId",
                table: "HospitalUsingFacilities",
                column: "HospitalSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingFacilities_IndustryId",
                table: "HospitalUsingFacilities",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalGuidanceMonitoringConditions");

            migrationBuilder.DropTable(
                name: "HospitalTesterPersonnels");

            migrationBuilder.DropTable(
                name: "HospitalUsingFacilities");

            migrationBuilder.DropTable(
                name: "HospitalDisinfectionDeviceResults");

            migrationBuilder.DropTable(
                name: "HospitalSamplingResults");
        }
    }
}
