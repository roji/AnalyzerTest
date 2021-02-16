using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveOldEnergyAndWaterConsumptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyConsumptions");

            migrationBuilder.DropTable(
                name: "WaterConsumptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    EcAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    EcSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    EcSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    EcSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    EcWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GcAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GcSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GcSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GcSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    GcWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GlcAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GlcSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GlcSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GlcSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    GlcWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    HasElectricityConsumption = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasGasConsumption = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasGasolineConsumption = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasMazutConsumption = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    McAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    McSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    McSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    McSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    McWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyConsumptions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    CvAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    CvSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    CvSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    CvSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    CvWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    CwConsumptionPlacesIds = table.Column<string>(type: "longtext", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    GwAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GwConsumptionPlacesIds = table.Column<string>(type: "longtext", nullable: true),
                    GwSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GwSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    GwSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    GwWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    HasCityOrVillageWater = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasGroundWater = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasSeaWater = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasSurfaceWater = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    SeawAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SeawConsumptionPlacesIds = table.Column<string>(type: "longtext", nullable: true),
                    SeawSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SeawSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SeawSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    SeawWinterAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SwAutumnAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SwConsumptionPlacesIds = table.Column<string>(type: "longtext", nullable: true),
                    SwSpringAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SwSummerAverageConsumption = table.Column<int>(type: "int", nullable: true),
                    SwSupplySourceLocationName = table.Column<string>(type: "longtext", nullable: true),
                    SwWinterAverageConsumption = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterConsumptions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnergyConsumptions_IndustryId",
                table: "EnergyConsumptions",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterConsumptions_IndustryId",
                table: "WaterConsumptions",
                column: "IndustryId",
                unique: true);
        }
    }
}
