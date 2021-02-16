using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentCaseAdditionalInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentCaseAdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoadTypeId = table.Column<int>(nullable: true),
                    RoadTypeDescription = table.Column<string>(nullable: true),
                    RoadWidth = table.Column<double>(nullable: true),
                    RoadLength = table.Column<double>(nullable: true),
                    GroundShape = table.Column<string>(nullable: true),
                    WaterResourceStatus = table.Column<string>(nullable: true),
                    DustDepthAndType = table.Column<string>(nullable: true),
                    ClimateSituation = table.Column<string>(nullable: true),
                    VegetationCover = table.Column<string>(nullable: true),
                    StaticLevel = table.Column<string>(nullable: true),
                    AnimalDistribution = table.Column<string>(nullable: true),
                    IntendedLandUsageId = table.Column<int>(nullable: true),
                    NeighborLandUsageId = table.Column<int>(nullable: true),
                    InfrastructureBuildings = table.Column<string>(nullable: true),
                    DistanceFromIndustrialTownAndRegion = table.Column<double>(nullable: true),
                    DistanceFromIndustrialTownAndRegionDescription = table.Column<string>(nullable: true),
                    NorthDistanceFromResidentialUnits = table.Column<double>(nullable: true),
                    SouthDistanceFromResidentialUnits = table.Column<double>(nullable: true),
                    WestDistanceFromResidentialUnits = table.Column<double>(nullable: true),
                    EastDistanceFromResidentialUnits = table.Column<double>(nullable: true),
                    DistanceFromResidentialUnitsDescription = table.Column<string>(nullable: true),
                    ImportantRelatedRulesAndCode = table.Column<string>(nullable: true),
                    OtherDescription = table.Column<string>(nullable: true),
                    IsSelectedPlaceInQuadrupleArea = table.Column<bool>(nullable: true),
                    QuadrupleAreaId = table.Column<int>(nullable: true),
                    QuadrupleAreaTypeId = table.Column<int>(nullable: true),
                    QuadrupleAreaDescription = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryEstablishmentCaseAdditionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfos_Industries_Industry~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfos_EnumData_IntendedLa~",
                        column: x => x.IntendedLandUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfos_EnumData_NeighborLa~",
                        column: x => x.NeighborLandUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfos_EnumData_QuadrupleA~",
                        column: x => x.QuadrupleAreaId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfos_EnumData_Quadruple~1",
                        column: x => x.QuadrupleAreaTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfos_EnumData_RoadTypeId",
                        column: x => x.RoadTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentCaseAdditionalInfoDistances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DistanceFromCentersAreasEcosystemsId = table.Column<int>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IndustryEstablishmentCaseAdditionalInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentCaseAdditionalInfoDistances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfoDistances_EnumData_Di~",
                        column: x => x.DistanceFromCentersAreasEcosystemsId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentCaseAdditionalInfoDistances_IndustryEst~",
                        column: x => x.IndustryEstablishmentCaseAdditionalInfoId,
                        principalTable: "IndustryEstablishmentCaseAdditionalInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfoDistances_DistanceFro~",
                table: "IndustryEstablishmentCaseAdditionalInfoDistances",
                column: "DistanceFromCentersAreasEcosystemsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfoDistances_IndustryEst~",
                table: "IndustryEstablishmentCaseAdditionalInfoDistances",
                column: "IndustryEstablishmentCaseAdditionalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfos_IndustryId",
                table: "IndustryEstablishmentCaseAdditionalInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfos_IntendedLandUsageId",
                table: "IndustryEstablishmentCaseAdditionalInfos",
                column: "IntendedLandUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfos_NeighborLandUsageId",
                table: "IndustryEstablishmentCaseAdditionalInfos",
                column: "NeighborLandUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfos_QuadrupleAreaId",
                table: "IndustryEstablishmentCaseAdditionalInfos",
                column: "QuadrupleAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfos_QuadrupleAreaTypeId",
                table: "IndustryEstablishmentCaseAdditionalInfos",
                column: "QuadrupleAreaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentCaseAdditionalInfos_RoadTypeId",
                table: "IndustryEstablishmentCaseAdditionalInfos",
                column: "RoadTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEstablishmentCaseAdditionalInfoDistances");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentCaseAdditionalInfos");
        }
    }
}
