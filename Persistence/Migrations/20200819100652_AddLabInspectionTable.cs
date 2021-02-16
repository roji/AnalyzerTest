using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLabInspectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabInspections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(nullable: true),
                    IsLocationVerified = table.Column<bool>(nullable: true),
                    LocationVerifiedDescription = table.Column<string>(nullable: true),
                    IsParameterAndMeasurementMethodsVerified = table.Column<bool>(nullable: true),
                    ParameterAndMeasurementMethodsVerifiedDescription = table.Column<string>(nullable: true),
                    IsPersonnelsInformationVerified = table.Column<bool>(nullable: true),
                    PersonnelsInformationVerifiedDescription = table.Column<string>(nullable: true),
                    IsEquipmentInformationVerified = table.Column<bool>(nullable: true),
                    EquipmentInformationVerifiedDescription = table.Column<string>(nullable: true),
                    IsEquipmentSerialNumberVerified = table.Column<bool>(nullable: true),
                    EquipmentSerialNumberVerifiedDescription = table.Column<string>(nullable: true),
                    IsEquipmentModelNameVerified = table.Column<bool>(nullable: true),
                    EquipmentModelNameVerifiedDescription = table.Column<string>(nullable: true),
                    IsDeviceCalibrationLicenseVerified = table.Column<bool>(nullable: true),
                    DeviceCalibrationLicenseVerifiedDescription = table.Column<string>(nullable: true),
                    IsLabAreaVerified = table.Column<bool>(nullable: true),
                    LabAreaVerifiedDescription = table.Column<string>(nullable: true),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    DocumentDescription = table.Column<string>(nullable: true),
                    IsUnknownSampleDelivered = table.Column<bool>(nullable: true),
                    UnknownSampleDeliveredDescription = table.Column<string>(nullable: true),
                    IsPracticalTestPerformed = table.Column<bool>(nullable: true),
                    PracticalTestPerformedDescription = table.Column<string>(nullable: true),
                    IsComparativeTestMatch = table.Column<bool>(nullable: true),
                    ComparativeTestMatchDescription = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_LabInspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabInspections_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabInspections_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabInspections_DocumentFileNameId",
                table: "LabInspections",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LabInspections_LabId",
                table: "LabInspections",
                column: "LabId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabInspections");
        }
    }
}
