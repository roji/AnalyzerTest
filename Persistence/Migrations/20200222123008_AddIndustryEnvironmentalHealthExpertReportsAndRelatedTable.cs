using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEnvironmentalHealthExpertReportsAndRelatedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEnvironmentalHealthExpertReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasWasteManagementOperationProgram = table.Column<bool>(nullable: false),
                    IsProducedWasteIdentify = table.Column<bool>(nullable: false),
                    DoesCollectingInfectiousWaste = table.Column<bool>(nullable: false),
                    DoesKeepingChemicalMedicineWastes = table.Column<bool>(nullable: false),
                    DoesPlasticBagsFilledThreeQuarters = table.Column<bool>(nullable: false),
                    DoesCollectingInSafetyBox = table.Column<bool>(nullable: false),
                    DoesMercuryWasteSepration = table.Column<bool>(nullable: false),
                    DoesWashingWasteBuckets = table.Column<bool>(nullable: false),
                    DoesLabelingWastes = table.Column<bool>(nullable: false),
                    DoesCollectingRadioActiveWastes = table.Column<bool>(nullable: false),
                    DoesDisposingBodyParts = table.Column<bool>(nullable: false),
                    HasWasteTemporarySavingLocation = table.Column<bool>(nullable: false),
                    IsSavingLocationAwayOfAtmosphericFactors = table.Column<bool>(nullable: false),
                    IsSavingLocationIsMoistureImpermeable = table.Column<bool>(nullable: false),
                    IsSavingLocationCorruptionResistance = table.Column<bool>(nullable: false),
                    IsSavingLocationBagsShred = table.Column<bool>(nullable: false),
                    IsSavingLocationCleanable = table.Column<bool>(nullable: false),
                    IsSavingLocationHasEnoughSpace = table.Column<bool>(nullable: false),
                    IsSavingLocationHasProperSewageSystem = table.Column<bool>(nullable: false),
                    HasEnoughSpaceIfDisinfectionHappen = table.Column<bool>(nullable: false),
                    DoesRulesApplyToTemporaryKeepingWastes = table.Column<bool>(nullable: false),
                    HasEnoughSpaceAccordingToActiveBeds = table.Column<bool>(nullable: false),
                    IsDisinfectionHappenToAllKindOfWaste = table.Column<bool>(nullable: false),
                    IsDisinfectionMethodHasHealthMinisteryConfirmation = table.Column<bool>(nullable: false),
                    HasUserToWorkWithDevice = table.Column<bool>(nullable: false),
                    IsUserEducatedToWorkWithDevice = table.Column<bool>(nullable: false),
                    HasDeviceMonitoringWasteDocuments = table.Column<bool>(nullable: false),
                    DoesSavingDocumentsForAtLeastOneYear = table.Column<bool>(nullable: false),
                    HasDeviceCalibrationDocuments = table.Column<bool>(nullable: false),
                    UsingBiologicalIndexOnesPerMonth = table.Column<bool>(nullable: false),
                    IsValidationCheckingHappenWithPreVacuumAutoClave = table.Column<bool>(nullable: false),
                    DoesSendingSelfDeclarationForm = table.Column<bool>(nullable: false),
                    DisinfectionDeviceStatusId = table.Column<int>(nullable: false),
                    DisinfectionDeviceModel = table.Column<string>(nullable: true),
                    DisinfectionDeviceCompany = table.Column<string>(nullable: true),
                    DisinfectionDeviceLunchingDate = table.Column<int>(nullable: false),
                    DeviceShredderStatus = table.Column<bool>(nullable: false),
                    ShredderTypeId = table.Column<int>(nullable: false),
                    DoesShreddingSafetyBox = table.Column<bool>(nullable: false),
                    DisinfectionNonBurningDeviceSize = table.Column<double>(nullable: false),
                    DevicePressure = table.Column<double>(nullable: false),
                    DeviceTemperature = table.Column<double>(nullable: false),
                    SterileRetentionTime = table.Column<string>(nullable: true),
                    ChemicalIndexType = table.Column<string>(nullable: true),
                    CalibrationDate = table.Column<int>(nullable: false),
                    CalibrationDocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    UsingDisinfectantType = table.Column<string>(nullable: true),
                    DisinfectantConcentration = table.Column<string>(nullable: true),
                    UsingDisinfectantQuantity = table.Column<string>(nullable: true),
                    IsDirtWasteShreddingDuringDisinfectant = table.Column<bool>(nullable: false),
                    IsSharpWasteShreddingDuringDisinfectant = table.Column<bool>(nullable: false),
                    PathologicalWastesManagementMethod = table.Column<string>(nullable: true),
                    ChemicalWastesManagementMethod = table.Column<string>(nullable: true),
                    MedicineWastesManagementMethod = table.Column<string>(nullable: true),
                    GenotoxicWastesManagementMethod = table.Column<string>(nullable: true),
                    HeavyMetalsWastesManagementMethod = table.Column<string>(nullable: true),
                    RadiatorWastesManagementMethod = table.Column<string>(nullable: true),
                    PressureVesselsWastesManagementMethod = table.Column<string>(nullable: true),
                    NormalWastesManagementMethod = table.Column<string>(nullable: true),
                    HealthExpertFullName = table.Column<string>(nullable: true),
                    ReportDate = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEnvironmentalHealthExpertReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEnvironmentalHealthExpertReports_Uploads_Calibration~",
                        column: x => x.CalibrationDocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEnvironmentalHealthExpertReports_EnumData_Disinfecti~",
                        column: x => x.DisinfectionDeviceStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEnvironmentalHealthExpertReports_Industries_Industry~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEnvironmentalHealthExpertReports_EnumData_ShredderTy~",
                        column: x => x.ShredderTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryUsingOtherIndustryDisinfectionDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEnvironmentalHealthExpertReportId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryUsingOtherIndustryDisinfectionDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryUsingOtherIndustryDisinfectionDevices_IndustryEnviro~",
                        column: x => x.IndustryEnvironmentalHealthExpertReportId,
                        principalTable: "IndustryEnvironmentalHealthExpertReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryUsingOtherIndustryDisinfectionDevices_Industries_Ind~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEnvironmentalHealthExpertReports_CalibrationDocument~",
                table: "IndustryEnvironmentalHealthExpertReports",
                column: "CalibrationDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEnvironmentalHealthExpertReports_DisinfectionDeviceS~",
                table: "IndustryEnvironmentalHealthExpertReports",
                column: "DisinfectionDeviceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEnvironmentalHealthExpertReports_IndustryId",
                table: "IndustryEnvironmentalHealthExpertReports",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEnvironmentalHealthExpertReports_ShredderTypeId",
                table: "IndustryEnvironmentalHealthExpertReports",
                column: "ShredderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryUsingOtherIndustryDisinfectionDevices_IndustryEnviro~",
                table: "IndustryUsingOtherIndustryDisinfectionDevices",
                column: "IndustryEnvironmentalHealthExpertReportId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryUsingOtherIndustryDisinfectionDevices_IndustryId",
                table: "IndustryUsingOtherIndustryDisinfectionDevices",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryUsingOtherIndustryDisinfectionDevices");

            migrationBuilder.DropTable(
                name: "IndustryEnvironmentalHealthExpertReports");
        }
    }
}
