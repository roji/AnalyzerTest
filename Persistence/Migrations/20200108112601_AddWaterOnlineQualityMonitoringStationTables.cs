using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWaterOnlineQualityMonitoringStationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WaterOnlineQualityMonitoringStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    RiverId = table.Column<int>(nullable: false),
                    MainBasinId = table.Column<int>(nullable: false),
                    SecondaryBasinId = table.Column<int>(nullable: false),
                    RiverRangeId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterOnlineQualityMonitoringStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_MainBasinId",
                        column: x => x.MainBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_RiverRangeId",
                        column: x => x.RiverRangeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_SatisfactionLe~",
                        column: x => x.SatisfactionLevelId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_SecondaryBasin~",
                        column: x => x.SecondaryBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_StationDataSen~",
                        column: x => x.StationDataSendingFrequencyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_StationModelId",
                        column: x => x.StationModelId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_StationTypeId",
                        column: x => x.StationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStations_EnumData_StationUsageCl~",
                        column: x => x.StationUsageClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaterOnlineQualityMonitoringStation_Addresses",
                columns: table => new
                {
                    WaterOnlineQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterOnlineQualityMonitoringStation_Addresses", x => x.WaterOnlineQualityMonitoringStationId);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStation_Addresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStation_Addresses_EnumData_Provi~",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStation_Addresses_EnumData_State~",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStation_Addresses_WaterOnlineQua~",
                        column: x => x.WaterOnlineQualityMonitoringStationId,
                        principalTable: "WaterOnlineQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterOnlineQualityMonitoringStation_Managers",
                columns: table => new
                {
                    WaterOnlineQualityMonitoringStationId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterOnlineQualityMonitoringStation_Managers", x => x.WaterOnlineQualityMonitoringStationId);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStation_Managers_WaterOnlineQual~",
                        column: x => x.WaterOnlineQualityMonitoringStationId,
                        principalTable: "WaterOnlineQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterOnlineQualityMonitoringStationParametersAnalyzers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    StationParameterId = table.Column<int>(nullable: false),
                    WaterOnlineQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterOnlineQualityMonitoringStationParametersAnalyzers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStationParametersAnalyzers_EnumD~",
                        column: x => x.StationParameterId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStationParametersAnalyzers_Water~",
                        column: x => x.WaterOnlineQualityMonitoringStationId,
                        principalTable: "WaterOnlineQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterOnlineQualityMonitoringStationConsumables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationConsumableId = table.Column<int>(nullable: false),
                    WaterOnlineQualityMonitoringStationParametersAnalyzerId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterOnlineQualityMonitoringStationConsumables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStationConsumables_EnumData_Stat~",
                        column: x => x.StationConsumableId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStationConsumables_WaterOnlineQu~",
                        column: x => x.WaterOnlineQualityMonitoringStationParametersAnalyzerId,
                        principalTable: "WaterOnlineQualityMonitoringStationParametersAnalyzers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterOnlineQualityMonitoringStationSpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationSparePartId = table.Column<int>(nullable: false),
                    WaterOnlineQualityMonitoringStationParametersAnalyzerId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterOnlineQualityMonitoringStationSpareParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStationSpareParts_EnumData_Stati~",
                        column: x => x.StationSparePartId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterOnlineQualityMonitoringStationSpareParts_WaterOnlineQua~",
                        column: x => x.WaterOnlineQualityMonitoringStationParametersAnalyzerId,
                        principalTable: "WaterOnlineQualityMonitoringStationParametersAnalyzers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStation_Addresses_CityId",
                table: "WaterOnlineQualityMonitoringStation_Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStation_Addresses_ProvinceId",
                table: "WaterOnlineQualityMonitoringStation_Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStation_Addresses_StateId",
                table: "WaterOnlineQualityMonitoringStation_Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStationConsumables_StationConsum~",
                table: "WaterOnlineQualityMonitoringStationConsumables",
                column: "StationConsumableId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStationConsumables_WaterOnlineQu~",
                table: "WaterOnlineQualityMonitoringStationConsumables",
                column: "WaterOnlineQualityMonitoringStationParametersAnalyzerId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStationParametersAnalyzers_Stati~",
                table: "WaterOnlineQualityMonitoringStationParametersAnalyzers",
                column: "StationParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStationParametersAnalyzers_Water~",
                table: "WaterOnlineQualityMonitoringStationParametersAnalyzers",
                column: "WaterOnlineQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_MainBasinId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "MainBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_RiverId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_RiverRangeId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "RiverRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_SatisfactionLevelId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "SatisfactionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_SecondaryBasinId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "SecondaryBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_StationDataSendingFrequ~",
                table: "WaterOnlineQualityMonitoringStations",
                column: "StationDataSendingFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_StationModelId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "StationModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_StationTypeId",
                table: "WaterOnlineQualityMonitoringStations",
                column: "StationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStations_StationUsageClassificat~",
                table: "WaterOnlineQualityMonitoringStations",
                column: "StationUsageClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStationSpareParts_StationSparePa~",
                table: "WaterOnlineQualityMonitoringStationSpareParts",
                column: "StationSparePartId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterOnlineQualityMonitoringStationSpareParts_WaterOnlineQua~",
                table: "WaterOnlineQualityMonitoringStationSpareParts",
                column: "WaterOnlineQualityMonitoringStationParametersAnalyzerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterOnlineQualityMonitoringStation_Addresses");

            migrationBuilder.DropTable(
                name: "WaterOnlineQualityMonitoringStation_Managers");

            migrationBuilder.DropTable(
                name: "WaterOnlineQualityMonitoringStationConsumables");

            migrationBuilder.DropTable(
                name: "WaterOnlineQualityMonitoringStationSpareParts");

            migrationBuilder.DropTable(
                name: "WaterOnlineQualityMonitoringStationParametersAnalyzers");

            migrationBuilder.DropTable(
                name: "WaterOnlineQualityMonitoringStations");
        }
    }
}
