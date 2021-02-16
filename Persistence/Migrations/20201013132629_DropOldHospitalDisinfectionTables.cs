using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DropOldHospitalDisinfectionTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalSamplingResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DepartmentAlternativeLetterDate = table.Column<int>(type: "int", nullable: true),
                    DepartmentAlternativeLetterNumber = table.Column<int>(type: "int", nullable: true),
                    DepartmentLetterDate = table.Column<int>(type: "int", nullable: true),
                    DepartmentLetterNumber = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    EliminateOtherHospitalsWaste = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ExperimentReason = table.Column<int>(type: "int", nullable: false),
                    ExperimentReasonDescription = table.Column<string>(type: "longtext", nullable: true),
                    ExperimentSubject = table.Column<string>(type: "longtext", nullable: true),
                    FinalSave = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    HasDisinfectionDevicePollution = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HasPollution = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HasWastePollution = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HospitalContractFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    IsDevicesResultsAcceptable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsEliminationHappenInHospital = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsMonitoringCenterSite = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsMonitoringDone = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    LabId = table.Column<int>(type: "int", nullable: false),
                    LabManagerVerifierId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    MonitoringAlternativeDate = table.Column<int>(type: "int", nullable: true),
                    MonitoringAlternativeHour = table.Column<string>(type: "longtext", nullable: true),
                    MonitoringCancelingCause = table.Column<string>(type: "longtext", nullable: true),
                    MonitoringDate = table.Column<int>(type: "int", nullable: true),
                    MonitoringHour = table.Column<string>(type: "longtext", nullable: true),
                    MonitoringPeriodId = table.Column<int>(type: "int", nullable: true),
                    MonitoringYear = table.Column<int>(type: "int", nullable: true),
                    OrganizationRepresentativeAttendance = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    OrganizationRepresentativeAttendanceFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    PollutionDescription = table.Column<string>(type: "longtext", nullable: true),
                    RialVolume = table.Column<long>(type: "bigint", nullable: true),
                    SamplingAnnounceDate = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    SamplingExpertsDescription = table.Column<string>(type: "longtext", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DeviceType = table.Column<int>(type: "int", nullable: false),
                    DryHeatBiologicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    GravityAutoClaveBiologicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    GravityAutoClaveClassFiveSixChemicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    GravityAutoClaveGuidanceMonitoringCondition = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HospitalSamplingResultId = table.Column<int>(type: "int", nullable: false),
                    HydroAutoClaveBiologicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsAcceptable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    PreVacuumAutoClaveBiologicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    PreVacuumAutoClaveBowieDickChemicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    PreVacuumAutoClaveClassFiveSixChemicalIndex = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    PreVacuumAutoClaveGuidanceMonitoringCondition = table.Column<bool>(type: "tinyint(1)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    HospitalSamplingResultId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    PersonnelId = table.Column<int>(type: "int", nullable: false),
                    PersonnelType = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    HospitalSamplingResultId = table.Column<int>(type: "int", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    UsingFacilitiesType = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AutoClaveType = table.Column<int>(type: "int", nullable: false),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DisinfectionDeviceResultId = table.Column<int>(type: "int", nullable: false),
                    GuidanceMonitoringConditionId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
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
                column: "HospitalSamplingResultId",
                unique: true);

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
    }
}
