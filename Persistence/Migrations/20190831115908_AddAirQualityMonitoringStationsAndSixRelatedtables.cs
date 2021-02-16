using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAirQualityMonitoringStationsAndSixRelatedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirQualityMonitoringStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    InstallationYear = table.Column<int>(nullable: true),
                    LaunchingYear = table.Column<int>(nullable: true),
                    StationTypeId = table.Column<int>(nullable: true),
                    StationDataSendingFrequencyId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    WhyNotActiveDescription = table.Column<string>(nullable: true),
                    MonitoringBoard = table.Column<bool>(nullable: true),
                    StationKeepingStatus = table.Column<int>(nullable: true),
                    ContractorName = table.Column<string>(nullable: true),
                    ContractorPhone = table.Column<string>(nullable: true),
                    ContractStartDate = table.Column<int>(nullable: true),
                    ContractExpireDate = table.Column<int>(nullable: true),
                    ContractPrice = table.Column<double>(nullable: true),
                    SatisfactionLevelId = table.Column<int>(nullable: true),
                    StationUsageClassificationId = table.Column<int>(nullable: true),
                    StationModelId = table.Column<int>(nullable: true),
                    ManufacturerCompany = table.Column<string>(nullable: true),
                    SellerCompany = table.Column<string>(nullable: true),
                    NeededCostsToMeetRequirements = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_AirQualityMonitoringStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStations_EnumData_SatisfactionLevelId",
                        column: x => x.SatisfactionLevelId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStations_EnumData_StationDataSendingFreq~",
                        column: x => x.StationDataSendingFrequencyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStations_EnumData_StationModelId",
                        column: x => x.StationModelId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStations_EnumData_StationTypeId",
                        column: x => x.StationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStations_EnumData_StationUsageClassifica~",
                        column: x => x.StationUsageClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirQualityMonitoringStation_Addresses",
                columns: table => new
                {
                    AirQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AirQualityMonitoringStation_Addresses", x => x.AirQualityMonitoringStationId);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStation_Addresses_AirQualityMonitoringSt~",
                        column: x => x.AirQualityMonitoringStationId,
                        principalTable: "AirQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStation_Addresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStation_Addresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStation_Addresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirQualityMonitoringStation_Managers",
                columns: table => new
                {
                    AirQualityMonitoringStationId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirQualityMonitoringStation_Managers", x => x.AirQualityMonitoringStationId);
                    table.ForeignKey(
                        name: "FK_AirQualityMonitoringStation_Managers_AirQualityMonitoringSta~",
                        column: x => x.AirQualityMonitoringStationId,
                        principalTable: "AirQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirQualityStationConsumables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationConsumableId = table.Column<int>(nullable: false),
                    AirQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AirQualityStationConsumables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirQualityStationConsumables_AirQualityMonitoringStations_Ai~",
                        column: x => x.AirQualityMonitoringStationId,
                        principalTable: "AirQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirQualityStationConsumables_EnumData_StationConsumableId",
                        column: x => x.StationConsumableId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirQualityStationMeteorologicalSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationMeteorologicalSystemId = table.Column<int>(nullable: false),
                    AirQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AirQualityStationMeteorologicalSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirQualityStationMeteorologicalSystems_AirQualityMonitoringS~",
                        column: x => x.AirQualityMonitoringStationId,
                        principalTable: "AirQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirQualityStationMeteorologicalSystems_EnumData_StationMeteo~",
                        column: x => x.StationMeteorologicalSystemId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirQualityStationParametersAnalyzers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    AirQualityMonitoringStationParameterId = table.Column<int>(nullable: false),
                    AirQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AirQualityStationParametersAnalyzers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirQualityStationParametersAnalyzers_AirQualityMonitoringSta~",
                        column: x => x.AirQualityMonitoringStationId,
                        principalTable: "AirQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirQualityStationParametersAnalyzers_EnumData_AirQualityMoni~",
                        column: x => x.AirQualityMonitoringStationParameterId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirQualityStationSpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationSparePartId = table.Column<int>(nullable: false),
                    AirQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AirQualityStationSpareParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirQualityStationSpareParts_AirQualityMonitoringStations_Air~",
                        column: x => x.AirQualityMonitoringStationId,
                        principalTable: "AirQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirQualityStationSpareParts_EnumData_StationSparePartId",
                        column: x => x.StationSparePartId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStation_Addresses_CityId",
                table: "AirQualityMonitoringStation_Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStation_Addresses_ProvinceId",
                table: "AirQualityMonitoringStation_Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStation_Addresses_StateId",
                table: "AirQualityMonitoringStation_Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStations_SatisfactionLevelId",
                table: "AirQualityMonitoringStations",
                column: "SatisfactionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStations_StationDataSendingFrequencyId",
                table: "AirQualityMonitoringStations",
                column: "StationDataSendingFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStations_StationModelId",
                table: "AirQualityMonitoringStations",
                column: "StationModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStations_StationTypeId",
                table: "AirQualityMonitoringStations",
                column: "StationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityMonitoringStations_StationUsageClassificationId",
                table: "AirQualityMonitoringStations",
                column: "StationUsageClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationConsumables_AirQualityMonitoringStationId",
                table: "AirQualityStationConsumables",
                column: "AirQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationConsumables_StationConsumableId",
                table: "AirQualityStationConsumables",
                column: "StationConsumableId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationMeteorologicalSystems_AirQualityMonitoringS~",
                table: "AirQualityStationMeteorologicalSystems",
                column: "AirQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationMeteorologicalSystems_StationMeteorological~",
                table: "AirQualityStationMeteorologicalSystems",
                column: "StationMeteorologicalSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationParametersAnalyzers_AirQualityMonitoringSta~",
                table: "AirQualityStationParametersAnalyzers",
                column: "AirQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationParametersAnalyzers_AirQualityMonitoringSt~1",
                table: "AirQualityStationParametersAnalyzers",
                column: "AirQualityMonitoringStationParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationSpareParts_AirQualityMonitoringStationId",
                table: "AirQualityStationSpareParts",
                column: "AirQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationSpareParts_StationSparePartId",
                table: "AirQualityStationSpareParts",
                column: "StationSparePartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirQualityMonitoringStation_Addresses");

            migrationBuilder.DropTable(
                name: "AirQualityMonitoringStation_Managers");

            migrationBuilder.DropTable(
                name: "AirQualityStationConsumables");

            migrationBuilder.DropTable(
                name: "AirQualityStationMeteorologicalSystems");

            migrationBuilder.DropTable(
                name: "AirQualityStationParametersAnalyzers");

            migrationBuilder.DropTable(
                name: "AirQualityStationSpareParts");

            migrationBuilder.DropTable(
                name: "AirQualityMonitoringStations");
        }
    }
}
