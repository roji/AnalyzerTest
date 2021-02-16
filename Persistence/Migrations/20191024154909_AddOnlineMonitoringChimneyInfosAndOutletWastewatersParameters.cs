using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddOnlineMonitoringChimneyInfosAndOutletWastewatersParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnlineMonitoringChimneyInfosParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryOnlineMonitoringParametersId = table.Column<int>(nullable: false),
                    ChimneyInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_OnlineMonitoringChimneyInfosParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineMonitoringChimneyInfosParameters_ChimneysInfo_ChimneyI~",
                        column: x => x.ChimneyInfoId,
                        principalTable: "ChimneysInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineMonitoringChimneyInfosParameters_IndustryOnlineMonitor~",
                        column: x => x.IndustryOnlineMonitoringParametersId,
                        principalTable: "IndustryOnlineMonitoringParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineMonitoringOutletWastewatersParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryOnlineMonitoringParametersId = table.Column<int>(nullable: false),
                    OutletWastewatersId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_OnlineMonitoringOutletWastewatersParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineMonitoringOutletWastewatersParameters_IndustryOnlineMo~",
                        column: x => x.IndustryOnlineMonitoringParametersId,
                        principalTable: "IndustryOnlineMonitoringParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineMonitoringOutletWastewatersParameters_OutletWastewater~",
                        column: x => x.OutletWastewatersId,
                        principalTable: "OutletWastewaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineMonitoringChimneyInfosParameters_ChimneyInfoId",
                table: "OnlineMonitoringChimneyInfosParameters",
                column: "ChimneyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineMonitoringChimneyInfosParameters_IndustryOnlineMonitor~",
                table: "OnlineMonitoringChimneyInfosParameters",
                column: "IndustryOnlineMonitoringParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineMonitoringOutletWastewatersParameters_IndustryOnlineMo~",
                table: "OnlineMonitoringOutletWastewatersParameters",
                column: "IndustryOnlineMonitoringParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineMonitoringOutletWastewatersParameters_OutletWastewater~",
                table: "OnlineMonitoringOutletWastewatersParameters",
                column: "OutletWastewatersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnlineMonitoringChimneyInfosParameters");

            migrationBuilder.DropTable(
                name: "OnlineMonitoringOutletWastewatersParameters");
        }
    }
}
