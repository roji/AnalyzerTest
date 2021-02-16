using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHospitalSamplingResultAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_LandTypeId",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_SlaughterHouseClassifi~",
                table: "SlaughterHouseSpecialtyInfos");

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
                    ParametersListDescription = table.Column<string>(nullable: true),
                    RialVolume = table.Column<long>(nullable: true),
                    HospitalContractFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    OrganizationRepresentativeAttendanceFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    MonitoringYear = table.Column<int>(nullable: true),
                    MonitoringPeriodId = table.Column<int>(nullable: true),
                    LabManagerVerifierId = table.Column<int>(nullable: false),
                    SamplingExpertsDescription = table.Column<string>(nullable: true),
                    FinalSave = table.Column<bool>(nullable: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalSamplingResults_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    IsEliminationHappenInHospital = table.Column<bool>(nullable: false),
                    EliminateOtherHospitalsWaste = table.Column<bool>(nullable: false),
                    IsMonitoringCenterSite = table.Column<bool>(nullable: false),
                    DisinfectionDeviceTypeId = table.Column<int>(nullable: false),
                    PreVacuumAutoClaveBiologicalIndex = table.Column<bool>(nullable: false),
                    PreVacuumAutoClaveBowieDickChemicalIndex = table.Column<bool>(nullable: false),
                    PreVacuumAutoClaveClassFiveSixChemicalIndex = table.Column<bool>(nullable: false),
                    PreVacuumAutoClaveGuidanceMonitoringCondition = table.Column<bool>(nullable: false),
                    GravityAutoClaveGuidanceMonitoringCondition = table.Column<bool>(nullable: false),
                    GravityAutoClaveBiologicalIndex = table.Column<bool>(nullable: false),
                    GravityAutoClaveClassFiveSixChemicalIndex = table.Column<bool>(nullable: false),
                    HydroAutoClaveBiologicalIndex = table.Column<bool>(nullable: false),
                    DryHeatBiologicalIndex = table.Column<bool>(nullable: false),
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
                        name: "FK_HospitalDisinfectionDeviceResults_EnumData_DisinfectionDevic~",
                        column: x => x.DisinfectionDeviceTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalDisinfectionDeviceResults_HospitalSamplingResults_Ho~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalExperimentParametersClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParamClassificationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HospitalExperimentParametersClassifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalExperimentParametersClassifications_HospitalSampling~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalExperimentParametersClassifications_EnumData_ParamCl~",
                        column: x => x.ParamClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalMedicalWasteStatusResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApprovedBeds = table.Column<int>(nullable: false),
                    ActiveBeds = table.Column<int>(nullable: false),
                    IndustryEnvironmentHealthExpertFullName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_HospitalMedicalWasteStatusResults", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "HospitalUsingFacilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisinfectionDeviceResultId = table.Column<int>(nullable: false),
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
                        name: "FK_HospitalUsingFacilities_HospitalDisinfectionDeviceResults_Di~",
                        column: x => x.DisinfectionDeviceResultId,
                        principalTable: "HospitalDisinfectionDeviceResults",
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
                name: "HospitalUsingOtherIndustryDisinfectionDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicalWasteStatusResultId = table.Column<int>(nullable: false),
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
                name: "IX_HospitalDisinfectionDeviceResults_DisinfectionDeviceTypeId",
                table: "HospitalDisinfectionDeviceResults",
                column: "DisinfectionDeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalDisinfectionDeviceResults_HospitalSamplingResultId",
                table: "HospitalDisinfectionDeviceResults",
                column: "HospitalSamplingResultId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalExperimentParametersClassifications_HospitalSampling~",
                table: "HospitalExperimentParametersClassifications",
                column: "HospitalSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalExperimentParametersClassifications_ParamClassificat~",
                table: "HospitalExperimentParametersClassifications",
                column: "ParamClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalGuidanceMonitoringConditions_DisinfectionDeviceResul~",
                table: "HospitalGuidanceMonitoringConditions",
                column: "DisinfectionDeviceResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalGuidanceMonitoringConditions_GuidanceMonitoringCondi~",
                table: "HospitalGuidanceMonitoringConditions",
                column: "GuidanceMonitoringConditionId");

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
                name: "IX_HospitalUsingFacilities_DisinfectionDeviceResultId",
                table: "HospitalUsingFacilities",
                column: "DisinfectionDeviceResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingFacilities_IndustryId",
                table: "HospitalUsingFacilities",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingOtherIndustryDisinfectionDevices_IndustryId",
                table: "HospitalUsingOtherIndustryDisinfectionDevices",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalUsingOtherIndustryDisinfectionDevices_MedicalWasteSt~",
                table: "HospitalUsingOtherIndustryDisinfectionDevices",
                column: "MedicalWasteStatusResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_LandTypeId",
                table: "SlaughterHouseSpecialtyInfos",
                column: "LandTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_SlaughterHouseClassifi~",
                table: "SlaughterHouseSpecialtyInfos",
                column: "SlaughterHouseClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_LandTypeId",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_SlaughterHouseClassifi~",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropTable(
                name: "HospitalExperimentParametersClassifications");

            migrationBuilder.DropTable(
                name: "HospitalGuidanceMonitoringConditions");

            migrationBuilder.DropTable(
                name: "HospitalTesterPersonnels");

            migrationBuilder.DropTable(
                name: "HospitalUsingFacilities");

            migrationBuilder.DropTable(
                name: "HospitalUsingOtherIndustryDisinfectionDevices");

            migrationBuilder.DropTable(
                name: "HospitalDisinfectionDeviceResults");

            migrationBuilder.DropTable(
                name: "HospitalMedicalWasteStatusResults");

            migrationBuilder.DropTable(
                name: "HospitalSamplingResults");

            migrationBuilder.AddForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_LandTypeId",
                table: "SlaughterHouseSpecialtyInfos",
                column: "LandTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_EnumData_SlaughterHouseClassifi~",
                table: "SlaughterHouseSpecialtyInfos",
                column: "SlaughterHouseClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
