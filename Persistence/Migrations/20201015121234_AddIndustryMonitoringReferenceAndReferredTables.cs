using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryMonitoringReferenceAndReferredTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryMonitoringReferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTimeOffset>(nullable: false, defaultValue: new DateTimeOffset(new DateTime(2020, 10, 15, 12, 12, 32, 47, DateTimeKind.Unspecified).AddTicks(6556), new TimeSpan(0, 0, 0, 0, 0))),
                    MaximumReferenceForLabs = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    FirstPriorityRateDistance = table.Column<int>(nullable: false),
                    FirstPriorityRateParamInclusionPercentage = table.Column<int>(nullable: false),
                    SecondPriorityRateDistance = table.Column<int>(nullable: false),
                    SecondPriorityRateParamInclusionPercentage = table.Column<int>(nullable: false),
                    ThirdPriorityRateDistance = table.Column<int>(nullable: false),
                    ThirdPriorityRateParamInclusionPercentage = table.Column<int>(nullable: false),
                    FourthPriorityRateDistance = table.Column<int>(nullable: false),
                    FourthPriorityRateParamInclusionPercentage = table.Column<int>(nullable: false),
                    IndustriesStatus = table.Column<int>(nullable: false),
                    ShouldLabsPublicInfoChecked = table.Column<bool>(nullable: false),
                    ShouldLabsPersonnelChecked = table.Column<bool>(nullable: false),
                    ShouldLabsEquipmentChecked = table.Column<bool>(nullable: false),
                    ShouldLabsParameterAndMeasurementMethodChecked = table.Column<bool>(nullable: false),
                    ShouldLabsConsumingMaterialChecked = table.Column<bool>(nullable: false),
                    IndustryDoesntMonitoredBySameLabInPreviousSeason = table.Column<bool>(nullable: false),
                    ShouldCheckLabsMaximumRialVolume = table.Column<bool>(nullable: false),
                    MaximumRialVolume = table.Column<long>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryMonitoringReferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryMonitoringReferences_EnumData_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryMonitoringReferreds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReferenceId = table.Column<int>(nullable: false),
                    LabId = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
                    IsAccepted = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryMonitoringReferreds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryMonitoringReferreds_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryMonitoringReferreds_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryMonitoringReferreds_IndustryMonitoringReferences_Ref~",
                        column: x => x.ReferenceId,
                        principalTable: "IndustryMonitoringReferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryMonitoringReferences_SeasonId",
                table: "IndustryMonitoringReferences",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryMonitoringReferreds_IndustryId",
                table: "IndustryMonitoringReferreds",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryMonitoringReferreds_LabId",
                table: "IndustryMonitoringReferreds",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryMonitoringReferreds_ReferenceId",
                table: "IndustryMonitoringReferreds",
                column: "ReferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryMonitoringReferreds");

            migrationBuilder.DropTable(
                name: "IndustryMonitoringReferences");
        }
    }
}
