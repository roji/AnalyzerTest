using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHydrometryStationAndClosedYearsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HydrometryStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    DifinitiveCode = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    RiverId = table.Column<int>(nullable: false),
                    Zone = table.Column<string>(nullable: true),
                    MainBasinId = table.Column<int>(nullable: false),
                    SecondaryBasinId = table.Column<int>(nullable: false),
                    RiverRangeId = table.Column<int>(nullable: false),
                    HydrometryStationTypeId = table.Column<int>(nullable: true),
                    HydrometryEquipmentTypeId = table.Column<int>(nullable: false),
                    ReperTypeId = table.Column<int>(nullable: false),
                    DataLoggerCompanyId = table.Column<int>(nullable: false),
                    HydrometryBuilderCompanyId = table.Column<int>(nullable: false),
                    IsInBorder = table.Column<bool>(nullable: false),
                    IsBase = table.Column<bool>(nullable: true),
                    ClassificationCode = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    HasWaterSampling = table.Column<bool>(nullable: true),
                    HasSedimentSampling = table.Column<bool>(nullable: true),
                    HasFloorLoadSampling = table.Column<bool>(nullable: true),
                    HasEshel = table.Column<bool>(nullable: true),
                    HasLaminatedGraph = table.Column<bool>(nullable: true),
                    HasTlfryk = table.Column<bool>(nullable: true),
                    HasDataLogger = table.Column<bool>(nullable: true),
                    HasReper = table.Column<bool>(nullable: true),
                    ReperElevation = table.Column<double>(nullable: true),
                    HasQualitative = table.Column<bool>(nullable: true),
                    HasQualityPollution = table.Column<bool>(nullable: true),
                    HasHouse = table.Column<bool>(nullable: true),
                    HasBuildingBridge = table.Column<bool>(nullable: true),
                    HasBuiltBed = table.Column<bool>(nullable: true),
                    HasElectricity = table.Column<bool>(nullable: true),
                    HasWireless = table.Column<bool>(nullable: true),
                    HasPhone = table.Column<bool>(nullable: true),
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
                    table.PrimaryKey("PK_HydrometryStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_DataLoggerCompanyId",
                        column: x => x.DataLoggerCompanyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_HydrometryBuilderCompanyId",
                        column: x => x.HydrometryBuilderCompanyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_HydrometryEquipmentTypeId",
                        column: x => x.HydrometryEquipmentTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_HydrometryStationTypeId",
                        column: x => x.HydrometryStationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_MainBasinId",
                        column: x => x.MainBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_ReperTypeId",
                        column: x => x.ReperTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_RiverRangeId",
                        column: x => x.RiverRangeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStations_EnumData_SecondaryBasinId",
                        column: x => x.SecondaryBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HydrometryStation_Addresses",
                columns: table => new
                {
                    HydrometryStationId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    IndustrialTown = table.Column<string>(nullable: true),
                    AddressDetails = table.Column<string>(nullable: true),
                    IsInTownEnv = table.Column<bool>(nullable: true),
                    DistanceToCity = table.Column<int>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Elevation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydrometryStation_Addresses", x => x.HydrometryStationId);
                    table.ForeignKey(
                        name: "FK_HydrometryStation_Addresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStation_Addresses_HydrometryStations_HydrometrySta~",
                        column: x => x.HydrometryStationId,
                        principalTable: "HydrometryStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HydrometryStation_Addresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStation_Addresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HydrometryStationClosedYears",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    HydrometryStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HydrometryStationClosedYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydrometryStationClosedYears_HydrometryStations_HydrometrySt~",
                        column: x => x.HydrometryStationId,
                        principalTable: "HydrometryStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStation_Addresses_CityId",
                table: "HydrometryStation_Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStation_Addresses_ProvinceId",
                table: "HydrometryStation_Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStation_Addresses_StateId",
                table: "HydrometryStation_Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStationClosedYears_HydrometryStationId",
                table: "HydrometryStationClosedYears",
                column: "HydrometryStationId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_DataLoggerCompanyId",
                table: "HydrometryStations",
                column: "DataLoggerCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_HydrometryBuilderCompanyId",
                table: "HydrometryStations",
                column: "HydrometryBuilderCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_HydrometryEquipmentTypeId",
                table: "HydrometryStations",
                column: "HydrometryEquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_HydrometryStationTypeId",
                table: "HydrometryStations",
                column: "HydrometryStationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_MainBasinId",
                table: "HydrometryStations",
                column: "MainBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_ReperTypeId",
                table: "HydrometryStations",
                column: "ReperTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_RiverId",
                table: "HydrometryStations",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_RiverRangeId",
                table: "HydrometryStations",
                column: "RiverRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStations_SecondaryBasinId",
                table: "HydrometryStations",
                column: "SecondaryBasinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HydrometryStation_Addresses");

            migrationBuilder.DropTable(
                name: "HydrometryStationClosedYears");

            migrationBuilder.DropTable(
                name: "HydrometryStations");
        }
    }
}
