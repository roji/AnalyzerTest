using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddOnlineMonitoringAndTwoRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryOnlineMonitorings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OnlineMonitoringType = table.Column<int>(nullable: false),
                    NeedOnlineMonitoring = table.Column<bool>(nullable: false),
                    MeasureAbility = table.Column<bool>(nullable: true),
                    MaDescription = table.Column<string>(nullable: true),
                    HasOnlineMonitoringEquipments = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryOnlineMonitorings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryOnlineMonitorings_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryOnlineMonitoringEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryOnlineMonitoringId = table.Column<int>(nullable: false),
                    ChimneysInfoId = table.Column<int>(nullable: true),
                    OutletWastewaterId = table.Column<int>(nullable: true),
                    MonitoringDeviceSetupLocation = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<string>(maxLength: 500, nullable: true),
                    DeviceSetupYear = table.Column<int>(nullable: true),
                    DeviceSellerCompanyName = table.Column<string>(maxLength: 500, nullable: true),
                    SellerSupportQuality = table.Column<int>(nullable: true),
                    SsqDescription = table.Column<string>(nullable: true),
                    DeviceFunctioningSatisfaction = table.Column<int>(nullable: true),
                    DfsDescription = table.Column<string>(nullable: true),
                    SamplingSystem = table.Column<int>(nullable: true),
                    OnlineMonitoringInformationConnectionLink = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryOnlineMonitoringEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryOnlineMonitoringEquipments_ChimneysInfo_ChimneysInfo~",
                        column: x => x.ChimneysInfoId,
                        principalTable: "ChimneysInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryOnlineMonitoringEquipments_IndustryOnlineMonitorings~",
                        column: x => x.IndustryOnlineMonitoringId,
                        principalTable: "IndustryOnlineMonitorings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryOnlineMonitoringEquipments_OutletWastewaters_OutletW~",
                        column: x => x.OutletWastewaterId,
                        principalTable: "OutletWastewaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryOnlineMonitoringParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryOnlineMonitoringId = table.Column<int>(nullable: false),
                    ParameterId = table.Column<int>(nullable: false),
                    MonitoringSystemActivityStatus = table.Column<bool>(nullable: true),
                    MsasDescription = table.Column<string>(nullable: true),
                    OnlineStatus = table.Column<bool>(nullable: true),
                    OnlineStatusDescription = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryOnlineMonitoringParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryOnlineMonitoringParameters_IndustryOnlineMonitorings~",
                        column: x => x.IndustryOnlineMonitoringId,
                        principalTable: "IndustryOnlineMonitorings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryOnlineMonitoringParameters_EnumData_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryOnlineMonitoringEquipments_ChimneysInfoId",
                table: "IndustryOnlineMonitoringEquipments",
                column: "ChimneysInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryOnlineMonitoringEquipments_IndustryOnlineMonitoringId",
                table: "IndustryOnlineMonitoringEquipments",
                column: "IndustryOnlineMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryOnlineMonitoringEquipments_OutletWastewaterId",
                table: "IndustryOnlineMonitoringEquipments",
                column: "OutletWastewaterId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryOnlineMonitoringParameters_IndustryOnlineMonitoringId",
                table: "IndustryOnlineMonitoringParameters",
                column: "IndustryOnlineMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryOnlineMonitoringParameters_ParameterId",
                table: "IndustryOnlineMonitoringParameters",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryOnlineMonitorings_IndustryId",
                table: "IndustryOnlineMonitorings",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryOnlineMonitoringEquipments");

            migrationBuilder.DropTable(
                name: "IndustryOnlineMonitoringParameters");

            migrationBuilder.DropTable(
                name: "IndustryOnlineMonitorings");
        }
    }
}
