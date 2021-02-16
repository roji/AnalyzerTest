using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTwoTablesRelatedtoLivestockSpecialtyInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.CreateTable(
                name: "LivestockSpecialtyAdditionalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasUnderCultivationArea = table.Column<bool>(nullable: true),
                    UnderCultivationArea = table.Column<double>(nullable: true),
                    UnderCultivationSpecies = table.Column<string>(nullable: true),
                    ExpertFullName = table.Column<string>(nullable: true),
                    ExpertNationalCode = table.Column<string>(nullable: true),
                    ExpertStartContractDate = table.Column<int>(nullable: true),
                    ExpertEndContractDate = table.Column<int>(nullable: true),
                    ExpertContractFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    IsThereAnyHospitalNear = table.Column<bool>(nullable: true),
                    NearHospitals = table.Column<string>(nullable: true),
                    IsThereAnyAirportNear = table.Column<bool>(nullable: true),
                    NearAirports = table.Column<string>(nullable: true),
                    IsThereAnyBarrackNear = table.Column<bool>(nullable: true),
                    NearBarracks = table.Column<string>(nullable: true),
                    IsThereAnyRiverNear = table.Column<bool>(nullable: true),
                    NearRivers = table.Column<string>(nullable: true),
                    IsThereAnySeaNear = table.Column<bool>(nullable: true),
                    NearSeas = table.Column<string>(nullable: true),
                    IsThereAnyWetlandNear = table.Column<bool>(nullable: true),
                    NearWetlands = table.Column<string>(nullable: true),
                    IsThereAnyFoodProductionUnitNear = table.Column<bool>(nullable: true),
                    NearFoodProductionUnits = table.Column<string>(nullable: true),
                    IsThereAnyIndustrialUnitNear = table.Column<bool>(nullable: true),
                    NearIndustrialUnits = table.Column<string>(nullable: true),
                    OtherNearUnits = table.Column<string>(nullable: true),
                    UnderGroundWaterDistanceToGround = table.Column<double>(nullable: true),
                    SoilTypeId = table.Column<int>(nullable: true),
                    AgreeToPeriodMonitoring = table.Column<bool>(nullable: true),
                    AgreeToObservedTransportationRules = table.Column<bool>(nullable: true),
                    AgreeToSectionNineInstruction = table.Column<bool>(nullable: true),
                    LivestockSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivestockSpecialtyAdditionalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyAdditionalInformations_Uploads_ExpertContr~",
                        column: x => x.ExpertContractFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyAdditionalInformations_LivestockSpecialtyI~",
                        column: x => x.LivestockSpecialtyInfoId,
                        principalTable: "LivestockSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyAdditionalInformations_EnumData_SoilTypeId",
                        column: x => x.SoilTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LivestockSpecialtyWasteInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SolidWasteQuantity = table.Column<double>(nullable: true),
                    ProcessedSolidWasteQuantity = table.Column<double>(nullable: true),
                    HasSelfUsageSolidWaste = table.Column<bool>(nullable: true),
                    SelfUsageSolidWasteQuantity = table.Column<double>(nullable: true),
                    HasSavingInFutureSolidWaste = table.Column<bool>(nullable: true),
                    SavingInFutureSolidWasteQuantity = table.Column<double>(nullable: true),
                    SavingInFitureSolidWasteStorageSize = table.Column<double>(nullable: true),
                    HasSolidWasteAssignedToFertilizerUnit = table.Column<bool>(nullable: true),
                    SolidWasteFertilizerUnitName = table.Column<string>(nullable: true),
                    SolidWasteFertilizerUnitContractFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    HasSolidWasteInOpenEnvironment = table.Column<bool>(nullable: true),
                    SolidWasteInOpenEnvironmentQuantity = table.Column<double>(nullable: true),
                    SolidWasteInOpenEnvioronmentKeepingPlace = table.Column<string>(nullable: true),
                    LiquidWasteQuantity = table.Column<double>(nullable: true),
                    ProcessedLiquidWasteQuantity = table.Column<double>(nullable: true),
                    LiquidFertilizerExtraSize = table.Column<double>(nullable: true),
                    HasSelfUsageLiquidWaste = table.Column<bool>(nullable: true),
                    SelfUsageLiquidWasteQuantity = table.Column<double>(nullable: true),
                    HasSavingInFutureLiquidWaste = table.Column<bool>(nullable: true),
                    SavingInFutureLiquidWasteQuantity = table.Column<double>(nullable: true),
                    SavingInFitureLiquidWasteStorageSize = table.Column<double>(nullable: true),
                    HasLiquidWasteAssignedToFertilizerUnit = table.Column<bool>(nullable: true),
                    LiquidWasteFertilizerUnitName = table.Column<string>(nullable: true),
                    LiquidWasteFertilizerUnitContractFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    HasLiquidWasteSendingToRefinery = table.Column<bool>(nullable: true),
                    LiquidWasteSendingToRefineryQuantity = table.Column<double>(nullable: true),
                    HasLiquidWasteReleaseInOpenEnvironment = table.Column<bool>(nullable: true),
                    LiquidWasteReleaseInOpenEnvironmentQuantity = table.Column<double>(nullable: true),
                    LiquidWasteInOpenEnvioronmentReleasePlace = table.Column<string>(nullable: true),
                    LiquidWasteInOpenEnvioronmentPlaceType = table.Column<string>(nullable: true),
                    LivestockSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivestockSpecialtyWasteInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyWasteInformations_Uploads_LiquidWasteFerti~",
                        column: x => x.LiquidWasteFertilizerUnitContractFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyWasteInformations_LivestockSpecialtyInfos_~",
                        column: x => x.LivestockSpecialtyInfoId,
                        principalTable: "LivestockSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyWasteInformations_Uploads_SolidWasteFertil~",
                        column: x => x.SolidWasteFertilizerUnitContractFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyAdditionalInformations_ExpertContractFileN~",
                table: "LivestockSpecialtyAdditionalInformations",
                column: "ExpertContractFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyAdditionalInformations_LivestockSpecialtyI~",
                table: "LivestockSpecialtyAdditionalInformations",
                column: "LivestockSpecialtyInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyAdditionalInformations_SoilTypeId",
                table: "LivestockSpecialtyAdditionalInformations",
                column: "SoilTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyWasteInformations_LiquidWasteFertilizerUni~",
                table: "LivestockSpecialtyWasteInformations",
                column: "LiquidWasteFertilizerUnitContractFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyWasteInformations_LivestockSpecialtyInfoId",
                table: "LivestockSpecialtyWasteInformations",
                column: "LivestockSpecialtyInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyWasteInformations_SolidWasteFertilizerUnit~",
                table: "LivestockSpecialtyWasteInformations",
                column: "SolidWasteFertilizerUnitContractFileNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivestockSpecialtyAdditionalInformations");

            migrationBuilder.DropTable(
                name: "LivestockSpecialtyWasteInformations");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "LivestockSpecialtyDetails",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "LivestockSpecialtyDetails",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "LivestockSpecialtyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "LivestockSpecialtyDetails",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "LivestockSpecialtyDetails",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "LivestockSpecialtyDetails",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "LivestockSpecialtyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "LivestockSpecialtyDetails",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
