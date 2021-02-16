using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRefinerySpecialtyInfosAndRefinerySendingGasTypestables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefinerySpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasOutputFlare = table.Column<bool>(nullable: true),
                    FlareTypeId = table.Column<int>(nullable: true),
                    SendingGasToFlareQuantity = table.Column<double>(nullable: true),
                    FlareOutputTemperature = table.Column<int>(nullable: true),
                    HasCamera = table.Column<bool>(nullable: true),
                    HoldingDataTimeCycle = table.Column<int>(nullable: true),
                    CameraViewLink = table.Column<string>(nullable: true),
                    HasFuelPit = table.Column<bool>(nullable: true),
                    FuelPitQuantity = table.Column<int>(nullable: true),
                    FuelPitDescription = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_RefinerySpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefinerySpecialtyInfos_EnumData_FlareTypeId",
                        column: x => x.FlareTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefinerySpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefinerySendingGasTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SendingGasTypeId = table.Column<int>(nullable: false),
                    RefinerySpecialtyInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_RefinerySendingGasTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefinerySendingGasTypes_RefinerySpecialtyInfos_RefinerySpeci~",
                        column: x => x.RefinerySpecialtyInfoId,
                        principalTable: "RefinerySpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefinerySendingGasTypes_EnumData_SendingGasTypeId",
                        column: x => x.SendingGasTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefinerySendingGasTypes_RefinerySpecialtyInfoId",
                table: "RefinerySendingGasTypes",
                column: "RefinerySpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RefinerySendingGasTypes_SendingGasTypeId",
                table: "RefinerySendingGasTypes",
                column: "SendingGasTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefinerySpecialtyInfos_FlareTypeId",
                table: "RefinerySpecialtyInfos",
                column: "FlareTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefinerySpecialtyInfos_IndustryId",
                table: "RefinerySpecialtyInfos",
                column: "IndustryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefinerySendingGasTypes");

            migrationBuilder.DropTable(
                name: "RefinerySpecialtyInfos");
        }
    }
}
