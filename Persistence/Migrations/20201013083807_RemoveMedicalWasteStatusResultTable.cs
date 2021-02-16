using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveMedicalWasteStatusResultTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalUsingOtherIndustryDisinfectionDevices");

            migrationBuilder.DropTable(
                name: "HospitalMedicalWasteStatusResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalMedicalWasteStatusResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CalibrationDate = table.Column<int>(type: "int", nullable: false),
                    CalibrationDocumentFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    ChemicalIndexType = table.Column<string>(type: "longtext", nullable: true),
                    ChemicalWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DevicePressure = table.Column<double>(type: "double", nullable: false),
                    DeviceShredderStatus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeviceTemperature = table.Column<double>(type: "double", nullable: false),
                    DisinfectantConcentration = table.Column<string>(type: "longtext", nullable: true),
                    DisinfectionDeviceCompany = table.Column<string>(type: "longtext", nullable: true),
                    DisinfectionDeviceLunchingDate = table.Column<int>(type: "int", nullable: false),
                    DisinfectionDeviceModel = table.Column<string>(type: "longtext", nullable: true),
                    DisinfectionDeviceStatusId = table.Column<int>(type: "int", nullable: false),
                    DisinfectionNonBurningDeviceSize = table.Column<double>(type: "double", nullable: false),
                    DoesCollectingInSafetyBox = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesCollectingInfectiousWaste = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesCollectingRadioActiveWastes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesDisposingBodyParts = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesKeepingChemicalMedicineWastes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesLabelingWastes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesMercuryWasteSepration = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesPlasticBagsFilledThreeQuarters = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesRulesApplyToTemporaryKeepingWastes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesSavingDocumentsForAtLeastOneYear = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesSendingSelfDeclarationForm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesShreddingSafetyBox = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DoesWashingWasteBuckets = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GenotoxicWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    HasDeviceCalibrationDocuments = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasDeviceMonitoringWasteDocuments = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasEnoughSpaceAccordingToActiveBeds = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasEnoughSpaceIfDisinfectionHappen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasUserToWorkWithDevice = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasWasteManagementOperationProgram = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasWasteTemporarySavingLocation = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HeavyMetalsWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    HospitalSamplingResultId = table.Column<int>(type: "int", nullable: false),
                    IsDirtWasteShreddingDuringDisinfectant = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDisinfectionHappenToAllKindOfWaste = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDisinfectionMethodHasHealthMinisteryConfirmation = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsProducedWasteIdentify = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationAwayOfAtmosphericFactors = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationBagsShred = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationCleanable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationCorruptionResistance = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationHasEnoughSpace = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationHasProperSewageSystem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSavingLocationIsMoistureImpermeable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSharpWasteShreddingDuringDisinfectant = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsUserEducatedToWorkWithDevice = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsValidationCheckingHappenWithPreVacuumAutoClave = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicineWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    NormalWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    PathologicalWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    PressureVesselsWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    RadiatorWastesManagementMethod = table.Column<string>(type: "longtext", nullable: true),
                    ShredderTypeId = table.Column<int>(type: "int", nullable: false),
                    SterileRetentionTime = table.Column<string>(type: "longtext", nullable: true),
                    UsingBiologicalIndexOnesPerMonth = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UsingDisinfectantQuantity = table.Column<string>(type: "longtext", nullable: true),
                    UsingDisinfectantType = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalMedicalWasteStatusResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalMedicalWasteStatusResults_Uploads_CalibrationDocumen~",
                        column: x => x.CalibrationDocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalMedicalWasteStatusResults_EnumData_DisinfectionDevic~",
                        column: x => x.DisinfectionDeviceStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalMedicalWasteStatusResults_HospitalSamplingResults_Ho~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalMedicalWasteStatusResults_EnumData_ShredderTypeId",
                        column: x => x.ShredderTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalUsingOtherIndustryDisinfectionDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    MedicalWasteStatusResultId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalUsingOtherIndustryDisinfectionDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalUsingOtherIndustryDisinfectionDevices_Industries_Ind~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalUsingOtherIndustryDisinfectionDevices_HospitalMedica~",
                        column: x => x.MedicalWasteStatusResultId,
                        principalTable: "HospitalMedicalWasteStatusResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalWasteStatusResults_CalibrationDocumentFileNam~",
                table: "HospitalMedicalWasteStatusResults",
                column: "CalibrationDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalWasteStatusResults_DisinfectionDeviceStatusId",
                table: "HospitalMedicalWasteStatusResults",
                column: "DisinfectionDeviceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalWasteStatusResults_HospitalSamplingResultId",
                table: "HospitalMedicalWasteStatusResults",
                column: "HospitalSamplingResultId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalWasteStatusResults_ShredderTypeId",
                table: "HospitalMedicalWasteStatusResults",
                column: "ShredderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingOtherIndustryDisinfectionDevices_IndustryId",
                table: "HospitalUsingOtherIndustryDisinfectionDevices",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingOtherIndustryDisinfectionDevices_MedicalWasteSt~",
                table: "HospitalUsingOtherIndustryDisinfectionDevices",
                column: "MedicalWasteStatusResultId");
        }
    }
}
