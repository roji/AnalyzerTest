using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Add8NewTablesindustryinspectionWarningAndPollutionSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryInspections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    InspectReasonId = table.Column<int>(nullable: true),
                    InspectDescription = table.Column<string>(nullable: true),
                    InspectDocumentFileName = table.Column<string>(nullable: true),
                    InspectingDate = table.Column<int>(nullable: true),
                    InspectingHour = table.Column<string>(maxLength: 50, nullable: true),
                    InspectingAgendaFileName = table.Column<string>(nullable: true),
                    InspectingExpertReportFileName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryInspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryInspections_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryInspections_EnumData_InspectReasonId",
                        column: x => x.InspectReasonId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryPollutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    AnnouncementDate = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    SeasonId = table.Column<int>(nullable: true),
                    PollutionTypeId = table.Column<int>(nullable: true),
                    PollutionDetectionCommitteeFileName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryPollutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryPollutions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryPollutions_EnumData_PollutionTypeId",
                        column: x => x.PollutionTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryPollutions_EnumData_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryWarnings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    WarningDate = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    WarningDocumentFileName = table.Column<string>(nullable: true),
                    FaxMailDate = table.Column<int>(nullable: true),
                    IndustryCommittedActions = table.Column<string>(nullable: true),
                    AdministrationLetterDate = table.Column<int>(nullable: true),
                    AdministrationLetterNumber = table.Column<string>(nullable: true),
                    IndustryCommittedActionsResult = table.Column<string>(nullable: true),
                    CommittedResultPercentage = table.Column<int>(nullable: true),
                    PercentageTillDate = table.Column<int>(nullable: true),
                    CrpDescription = table.Column<string>(nullable: true),
                    CommentDate = table.Column<int>(nullable: true),
                    GeneralAdministrationOpinionId = table.Column<int>(nullable: true),
                    ProgressPercentage = table.Column<int>(nullable: true),
                    ProgressDescription = table.Column<string>(nullable: true),
                    PossibleNextInspection = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryWarnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryWarnings_EnumData_GeneralAdministrationOpinionId",
                        column: x => x.GeneralAdministrationOpinionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryWarnings_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryInspectingMonitoringTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryInspectionId = table.Column<int>(nullable: false),
                    MonitoringTypeQualityStatusId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DocumentFileName = table.Column<string>(nullable: true),
                    IsMeasured = table.Column<bool>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryInspectingMonitoringTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryInspectingMonitoringTypes_IndustryInspections_Indust~",
                        column: x => x.IndustryInspectionId,
                        principalTable: "IndustryInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryInspectingMonitoringTypes_EnumData_MonitoringTypeQua~",
                        column: x => x.MonitoringTypeQualityStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryInspectingPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryInspectionId = table.Column<int>(nullable: false),
                    Place = table.Column<string>(maxLength: 1000, nullable: false),
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
                    table.PrimaryKey("PK_IndustryInspectingPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryInspectingPlaces_IndustryInspections_IndustryInspect~",
                        column: x => x.IndustryInspectionId,
                        principalTable: "IndustryInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryInspectors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryInspectionId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 300, nullable: false),
                    Rank = table.Column<string>(maxLength: 500, nullable: true),
                    InspectorType = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryInspectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryInspectors_IndustryInspections_IndustryInspectionId",
                        column: x => x.IndustryInspectionId,
                        principalTable: "IndustryInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryPollutionReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryPollutionId = table.Column<int>(nullable: false),
                    IndustryInspectionId = table.Column<int>(nullable: true),
                    IndustrialUnitsSamplingResultId = table.Column<int>(nullable: true),
                    PollutionAnnouncementReason = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryPollutionReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryPollutionReasons_IndustrialUnitsSamplingResults_Indu~",
                        column: x => x.IndustrialUnitsSamplingResultId,
                        principalTable: "IndustrialUnitsSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryPollutionReasons_IndustryInspections_IndustryInspect~",
                        column: x => x.IndustryInspectionId,
                        principalTable: "IndustryInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryPollutionReasons_IndustryPollutions_IndustryPollutio~",
                        column: x => x.IndustryPollutionId,
                        principalTable: "IndustryPollutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryWarningReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryWarningId = table.Column<int>(nullable: false),
                    PreviousIndustryWarningId = table.Column<int>(nullable: true),
                    IndustryInspectionId = table.Column<int>(nullable: true),
                    IndustrialUnitsSamplingResultId = table.Column<int>(nullable: true),
                    WarningReason = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryWarningReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryWarningReasons_IndustrialUnitsSamplingResults_Indust~",
                        column: x => x.IndustrialUnitsSamplingResultId,
                        principalTable: "IndustrialUnitsSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryWarningReasons_IndustryInspections_IndustryInspectio~",
                        column: x => x.IndustryInspectionId,
                        principalTable: "IndustryInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryWarningReasons_IndustryWarnings_IndustryWarningId",
                        column: x => x.IndustryWarningId,
                        principalTable: "IndustryWarnings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryWarningReasons_IndustryWarnings_PreviousIndustryWarn~",
                        column: x => x.PreviousIndustryWarningId,
                        principalTable: "IndustryWarnings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspectingMonitoringTypes_IndustryInspectionId",
                table: "IndustryInspectingMonitoringTypes",
                column: "IndustryInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspectingMonitoringTypes_MonitoringTypeQualityStatu~",
                table: "IndustryInspectingMonitoringTypes",
                column: "MonitoringTypeQualityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspectingPlaces_IndustryInspectionId",
                table: "IndustryInspectingPlaces",
                column: "IndustryInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_IndustryId",
                table: "IndustryInspections",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_InspectReasonId",
                table: "IndustryInspections",
                column: "InspectReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspectors_IndustryInspectionId",
                table: "IndustryInspectors",
                column: "IndustryInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutionReasons_IndustrialUnitsSamplingResultId",
                table: "IndustryPollutionReasons",
                column: "IndustrialUnitsSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutionReasons_IndustryInspectionId",
                table: "IndustryPollutionReasons",
                column: "IndustryInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutionReasons_IndustryPollutionId",
                table: "IndustryPollutionReasons",
                column: "IndustryPollutionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutions_IndustryId",
                table: "IndustryPollutions",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutions_PollutionTypeId",
                table: "IndustryPollutions",
                column: "PollutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutions_SeasonId",
                table: "IndustryPollutions",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarningReasons_IndustrialUnitsSamplingResultId",
                table: "IndustryWarningReasons",
                column: "IndustrialUnitsSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarningReasons_IndustryInspectionId",
                table: "IndustryWarningReasons",
                column: "IndustryInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarningReasons_IndustryWarningId",
                table: "IndustryWarningReasons",
                column: "IndustryWarningId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarningReasons_PreviousIndustryWarningId",
                table: "IndustryWarningReasons",
                column: "PreviousIndustryWarningId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_GeneralAdministrationOpinionId",
                table: "IndustryWarnings",
                column: "GeneralAdministrationOpinionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_IndustryId",
                table: "IndustryWarnings",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryInspectingMonitoringTypes");

            migrationBuilder.DropTable(
                name: "IndustryInspectingPlaces");

            migrationBuilder.DropTable(
                name: "IndustryInspectors");

            migrationBuilder.DropTable(
                name: "IndustryPollutionReasons");

            migrationBuilder.DropTable(
                name: "IndustryWarningReasons");

            migrationBuilder.DropTable(
                name: "IndustryPollutions");

            migrationBuilder.DropTable(
                name: "IndustryInspections");

            migrationBuilder.DropTable(
                name: "IndustryWarnings");
        }
    }
}
