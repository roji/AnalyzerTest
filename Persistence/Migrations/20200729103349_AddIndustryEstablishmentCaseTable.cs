using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentCaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentCases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnershipType = table.Column<int>(nullable: true),
                    ActivityType = table.Column<int>(nullable: true),
                    IsSmokeComingOutDuringActivity = table.Column<bool>(nullable: true),
                    SmokeComingOutDuringActivityDescription = table.Column<string>(nullable: true),
                    IsGasComingOutDuringActivity = table.Column<bool>(nullable: true),
                    GasComingOutDuringActivityDescription = table.Column<string>(nullable: true),
                    IsDustComingOutDuringActivity = table.Column<bool>(nullable: true),
                    DustComingOutDuringActivityDescription = table.Column<string>(nullable: true),
                    IsIndustryActivityProduceAnnoyingSound = table.Column<bool>(nullable: true),
                    IndustryActivityProduceAnnoyingSoundDescription = table.Column<string>(nullable: true),
                    HowFarSoundIsNoticeable = table.Column<int>(nullable: true),
                    HowFarSoundIsNoticeableDescription = table.Column<string>(nullable: true),
                    IsIndustryActivityCreateVibration = table.Column<bool>(nullable: true),
                    IndustryActivityCreateVibrationDescription = table.Column<string>(nullable: true),
                    IsIndustryActivityCreateRadiation = table.Column<bool>(nullable: true),
                    IndustryActivityCreateRadiationDescription = table.Column<string>(nullable: true),
                    IndustryGeographicalPosition = table.Column<int>(nullable: true),
                    IsOutsideLegalRegion = table.Column<bool>(nullable: true),
                    IndustryGeographicalLocation = table.Column<int>(nullable: true),
                    DistanceFromEnvironmentalProtection = table.Column<double>(nullable: true),
                    DistanceFromEducationalCenters = table.Column<double>(nullable: true),
                    DistanceFromLawEnforcementCenters = table.Column<double>(nullable: true),
                    DistanceFromHighwayTransitRoad = table.Column<double>(nullable: true),
                    DistanceFromMainRoad = table.Column<double>(nullable: true),
                    DistanceFromPark = table.Column<double>(nullable: true),
                    DistanceFromLake = table.Column<double>(nullable: true),
                    DistanceFromSea = table.Column<double>(nullable: true),
                    DistanceFromNationalPark = table.Column<double>(nullable: true),
                    DistanceFromProtectedAreas = table.Column<double>(nullable: true),
                    DistanceFromWildlifeSanctuary = table.Column<double>(nullable: true),
                    DistanceFromNationalNaturalEffect = table.Column<double>(nullable: true),
                    DistanceFromPermanentRiver = table.Column<double>(nullable: true),
                    DistanceFromExistingAqueduct = table.Column<double>(nullable: true),
                    DistanceFromDrinkingWaterWells = table.Column<double>(nullable: true),
                    DistanceFromAgriculturalWaterWells = table.Column<double>(nullable: true),
                    DistanceFromIndustrialWaterWells = table.Column<double>(nullable: true),
                    ChimneyOutputSpeedForecast = table.Column<double>(nullable: true),
                    ChimneyOutputGasTemperature = table.Column<double>(nullable: true),
                    ChimneyDominantWindSpeed = table.Column<double>(nullable: true),
                    ChimneyDominantWindDirection = table.Column<double>(nullable: true),
                    CommitmentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                    table.PrimaryKey("PK_IndustryEstablishmentCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCases_Uploads_CommitmentFileNameId",
                        column: x => x.CommitmentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCases_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCases_CommitmentFileNameId",
                table: "IndustryEstablishmentCases",
                column: "CommitmentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCases_IndustryId",
                table: "IndustryEstablishmentCases",
                column: "IndustryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEstablishmentCases");
        }
    }
}
