using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLandFillSpecialtyInfoAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandfillSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BurialMethodId = table.Column<int>(nullable: true),
                    SpecialIndustrialWasteDailyCollection = table.Column<double>(nullable: true),
                    NormalIndustrialWasteDailyCollection = table.Column<double>(nullable: true),
                    SeperatedDryNormalWasteDailyCollection = table.Column<double>(nullable: true),
                    SeperatedWetNormalWasteDailyCollection = table.Column<double>(nullable: true),
                    NotSeperatedNormalWasteDailyCollection = table.Column<double>(nullable: true),
                    RejectedDryWasteCollection = table.Column<double>(nullable: true),
                    BurialDailyAverageQuantity = table.Column<double>(nullable: true),
                    HasReceiveDisinfectedMedicalWasteLicense = table.Column<bool>(nullable: true),
                    DisinfectedMedicalWasteFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    ReceiveMicrobialDisinfectedMedicalWasteQuantity = table.Column<double>(nullable: true),
                    HasReceiveNotDisinfectedMedicalWasteLicense = table.Column<bool>(nullable: true),
                    ReceiveNotDisinfectedMedicalWasteQuantity = table.Column<double>(nullable: true),
                    HasDailyUsageOfLimeWater = table.Column<bool>(nullable: true),
                    LimeWaterUsageMethod = table.Column<string>(nullable: true),
                    HasDailyEmbankment = table.Column<bool>(nullable: true),
                    EmbankmentUsageMethod = table.Column<string>(nullable: true),
                    EmbankmentPeriod = table.Column<int>(nullable: true),
                    CommitmentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    HasReceiveConstructionWasteLicense = table.Column<bool>(nullable: true),
                    ReceiveConstructionWasteQuantity = table.Column<double>(nullable: true),
                    HasSandExtractionUnit = table.Column<bool>(nullable: true),
                    SandExtractionUnitStorageSize = table.Column<double>(nullable: true),
                    HasCompostProductionAndRefiningUnit = table.Column<bool>(nullable: true),
                    CompostProductionAndRefiningUnitSotrageSize = table.Column<double>(nullable: true),
                    LeachateCollectionTankSize = table.Column<double>(nullable: true),
                    HasLeachateRefinery = table.Column<bool>(nullable: true),
                    DailyLeachateRefineryStorageSize = table.Column<double>(nullable: true),
                    LeachateUsageDescription = table.Column<string>(nullable: true),
                    HasGamenehPitForMethaneGasExtraction = table.Column<bool>(nullable: true),
                    PitQuantity = table.Column<int>(nullable: true),
                    MethaneProductionQuantity = table.Column<double>(nullable: true),
                    HasBurningRejectionSystem = table.Column<bool>(nullable: true),
                    DailyBurningRejectionQuantity = table.Column<double>(nullable: true),
                    BurningRejectionPowerGenerationCapacity = table.Column<double>(nullable: true),
                    HasAnaerobicDigesterSystem = table.Column<bool>(nullable: true),
                    DailyAnaerobicDigesterQuantity = table.Column<double>(nullable: true),
                    AnaerobicDigesterPowerGenerationCapacity = table.Column<double>(nullable: true),
                    RemainingSludgeInStorage = table.Column<double>(nullable: true),
                    SludgeUsageDescription = table.Column<string>(nullable: true),
                    HasAdvancedCompactorDevice = table.Column<bool>(nullable: true),
                    CompactDevicesQuantity = table.Column<int>(nullable: true),
                    DailyCompactingSize = table.Column<double>(nullable: true),
                    LandfillEstablishmentYear = table.Column<int>(nullable: true),
                    LandfillUsefulLife = table.Column<int>(nullable: true),
                    LandfillReceiveCapacityPerYear = table.Column<double>(nullable: true),
                    HasRecyclingMaterial = table.Column<bool>(nullable: true),
                    RecyclingMaterialDescription = table.Column<string>(nullable: true),
                    HasInstantPurificationFeature = table.Column<bool>(nullable: true),
                    InstantPurificationFeatureDescription = table.Column<string>(nullable: true),
                    InstantPurificationFeatureFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    HasEiaEvaluationSurveys = table.Column<bool>(nullable: true),
                    EiaEvaluationSurveysDescription = table.Column<string>(nullable: true),
                    PisometricPitUpstairsQuantity = table.Column<int>(nullable: true),
                    PisometricPitDownstreamQuantity = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_LandfillSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfos_EnumData_BurialMethodId",
                        column: x => x.BurialMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfos_Uploads_CommitmentFileNameId",
                        column: x => x.CommitmentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfos_Uploads_DisinfectedMedicalWasteFileNa~",
                        column: x => x.DisinfectedMedicalWasteFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfos_Uploads_InstantPurificationFeatureFil~",
                        column: x => x.InstantPurificationFeatureFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandfillSpecialtyInfoBurialInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteBurialPlaceObservedRules = table.Column<bool>(nullable: true),
                    WasteBurialPlaceObservedRulesDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotInRiverRange = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotInRiverRangeDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsOutOfFloodRange = table.Column<bool>(nullable: true),
                    BurialPlaceIsOutOfFloodRangeDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsOutOfWetlands = table.Column<bool>(nullable: true),
                    BurialPlaceIsOutOfWetlandsDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsOutOfRegionWaterResource = table.Column<bool>(nullable: true),
                    BurialPlaceIsOutOfRegionWaterResourceDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsOutOfUndergoundWaterSupplies = table.Column<bool>(nullable: true),
                    BurialPlaceIsOutOfUndergoundWaterSuppliesDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotDamWater = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotDamWaterDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotInAvalancheRegion = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotInAvalancheRegionDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotInValleyRegion = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotInValleyRegionDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNoInActiveFaultRegion = table.Column<bool>(nullable: true),
                    BurialPlaceIsNoInActiveFaultRegionDescription = table.Column<string>(nullable: true),
                    BurialPlaceSelectedRegionAreaObserveRules = table.Column<bool>(nullable: true),
                    BurialPlaceSelectedRegionAreaObserveRulesDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotInMineralResourcesRegion = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotInMineralResourcesRegionDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotInDominantWindsRegion = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotInDominantWindsRegionDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsNotInProtectedArea = table.Column<bool>(nullable: true),
                    BurialPlaceIsNotInProtectedAreaDescription = table.Column<string>(nullable: true),
                    BurialPlaceAestheticsObserveRules = table.Column<bool>(nullable: true),
                    BurialPlaceAestheticsObserveRulesDescription = table.Column<string>(nullable: true),
                    BurialPlaceRoadAccessWidthObserveRules = table.Column<bool>(nullable: true),
                    BurialPlaceRoadAccessWidthObserveRulesDescription = table.Column<string>(nullable: true),
                    BurialPlaceHasMinimalTraffic = table.Column<bool>(nullable: true),
                    BurialPlaceHasMinimalTrafficDescription = table.Column<string>(nullable: true),
                    BurialPlaceIsUsableInAllSeasons = table.Column<bool>(nullable: true),
                    BurialPlaceIsUsableInAllSeasonsDescription = table.Column<string>(nullable: true),
                    LandfillSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandfillSpecialtyInfoBurialInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfoBurialInformations_LandfillSpecialtyInf~",
                        column: x => x.LandfillSpecialtyInfoId,
                        principalTable: "LandfillSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandfillSpecialtyInfoTemporaryHoldingInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HoldingCapacity = table.Column<double>(nullable: true),
                    HasFencing = table.Column<bool>(nullable: true),
                    FencingDescription = table.Column<string>(nullable: true),
                    HasProperFloorCoveringInStoragePlace = table.Column<bool>(nullable: true),
                    ProperFloorCoveringInStoragePlaceDescription = table.Column<string>(nullable: true),
                    HasConcreteFlooring = table.Column<bool>(nullable: true),
                    ConcreteFlooringDescription = table.Column<string>(nullable: true),
                    HasGeotextileFloorCovering = table.Column<bool>(nullable: true),
                    GeotextileFloorCoveringDescription = table.Column<string>(nullable: true),
                    HasTwoCrushedClayLayer = table.Column<bool>(nullable: true),
                    TwoCrushedClayLayerDescription = table.Column<string>(nullable: true),
                    HasDrainageBlanket = table.Column<bool>(nullable: true),
                    DrainageBlanketDescription = table.Column<string>(nullable: true),
                    HasProperDrainageSystem = table.Column<bool>(nullable: true),
                    ProperDrainageSystemDescription = table.Column<string>(nullable: true),
                    HasImpermeableWalls = table.Column<bool>(nullable: true),
                    ImpermeableWallsDescription = table.Column<string>(nullable: true),
                    PutChemicalsTogetherProperly = table.Column<bool>(nullable: true),
                    PutChemicalsTogetherProperlyDescription = table.Column<string>(nullable: true),
                    HasDoubleWalledPolyethyleneTanks = table.Column<bool>(nullable: true),
                    DoubleWalledPolyethyleneTanksDescription = table.Column<string>(nullable: true),
                    HasSafetyEquipmentAndSupplies = table.Column<bool>(nullable: true),
                    SafetyEquipmentAndSuppliesDescription = table.Column<string>(nullable: true),
                    HasFireAlarm = table.Column<bool>(nullable: true),
                    FireAlarmDescription = table.Column<string>(nullable: true),
                    HasFireFighting = table.Column<bool>(nullable: true),
                    FireFightingDescription = table.Column<string>(nullable: true),
                    HasFirstAid = table.Column<bool>(nullable: true),
                    FirstAidDescription = table.Column<string>(nullable: true),
                    LandfillSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandfillSpecialtyInfoTemporaryHoldingInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfoTemporaryHoldingInformations_LandfillSp~",
                        column: x => x.LandfillSpecialtyInfoId,
                        principalTable: "LandfillSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandfillSpecialtyInfoWasteAcceptingIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LandfillSpecialtyInfoId = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
                    DailyAverageQuantity = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandfillSpecialtyInfoWasteAcceptingIndustries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfoWasteAcceptingIndustries_Industries_Ind~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandfillSpecialtyInfoWasteAcceptingIndustries_LandfillSpecia~",
                        column: x => x.LandfillSpecialtyInfoId,
                        principalTable: "LandfillSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfoBurialInformations_LandfillSpecialtyInf~",
                table: "LandfillSpecialtyInfoBurialInformations",
                column: "LandfillSpecialtyInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfos_BurialMethodId",
                table: "LandfillSpecialtyInfos",
                column: "BurialMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfos_CommitmentFileNameId",
                table: "LandfillSpecialtyInfos",
                column: "CommitmentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfos_DisinfectedMedicalWasteFileNameId",
                table: "LandfillSpecialtyInfos",
                column: "DisinfectedMedicalWasteFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfos_IndustryId",
                table: "LandfillSpecialtyInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfos_InstantPurificationFeatureFileNameId",
                table: "LandfillSpecialtyInfos",
                column: "InstantPurificationFeatureFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfoTemporaryHoldingInformations_LandfillSp~",
                table: "LandfillSpecialtyInfoTemporaryHoldingInformations",
                column: "LandfillSpecialtyInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfoWasteAcceptingIndustries_IndustryId",
                table: "LandfillSpecialtyInfoWasteAcceptingIndustries",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_LandfillSpecialtyInfoWasteAcceptingIndustries_LandfillSpecia~",
                table: "LandfillSpecialtyInfoWasteAcceptingIndustries",
                column: "LandfillSpecialtyInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandfillSpecialtyInfoBurialInformations");

            migrationBuilder.DropTable(
                name: "LandfillSpecialtyInfoTemporaryHoldingInformations");

            migrationBuilder.DropTable(
                name: "LandfillSpecialtyInfoWasteAcceptingIndustries");

            migrationBuilder.DropTable(
                name: "LandfillSpecialtyInfos");
        }
    }
}
