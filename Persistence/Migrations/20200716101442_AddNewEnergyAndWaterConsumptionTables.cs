using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewEnergyAndWaterConsumptionTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasElectricityConsumption = table.Column<bool>(nullable: false),
                    EcSupplySourceLocationName = table.Column<string>(nullable: true),
                    EcSpringAverageConsumption = table.Column<int>(nullable: true),
                    EcSummerAverageConsumption = table.Column<int>(nullable: true),
                    EcAutumnAverageConsumption = table.Column<int>(nullable: true),
                    EcWinterAverageConsumption = table.Column<int>(nullable: true),
                    HasGasConsumption = table.Column<bool>(nullable: false),
                    GcSupplySourceLocationName = table.Column<string>(nullable: true),
                    GcSpringAverageConsumption = table.Column<int>(nullable: true),
                    GcSummerAverageConsumption = table.Column<int>(nullable: true),
                    GcAutumnAverageConsumption = table.Column<int>(nullable: true),
                    GcWinterAverageConsumption = table.Column<int>(nullable: true),
                    HasMazutConsumption = table.Column<bool>(nullable: false),
                    McSupplySourceLocationName = table.Column<string>(nullable: true),
                    McSpringAverageConsumption = table.Column<int>(nullable: true),
                    McSummerAverageConsumption = table.Column<int>(nullable: true),
                    McAutumnAverageConsumption = table.Column<int>(nullable: true),
                    McWinterAverageConsumption = table.Column<int>(nullable: true),
                    HasGasolineConsumption = table.Column<bool>(nullable: false),
                    GlcSupplySourceLocationName = table.Column<string>(nullable: true),
                    GlcSpringAverageConsumption = table.Column<int>(nullable: true),
                    GlcSummerAverageConsumption = table.Column<int>(nullable: true),
                    GlcAutumnAverageConsumption = table.Column<int>(nullable: true),
                    GlcWinterAverageConsumption = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false, defaultValue: 1380),
                    GeneralManagerVote = table.Column<bool>(nullable: true),
                    GeneralManagerDescription = table.Column<string>(nullable: true),
                    GeneralManagerUserId = table.Column<int>(nullable: true),
                    ApprovingOrganizationVote = table.Column<bool>(nullable: true),
                    ApprovingOrganizationDescription = table.Column<string>(nullable: true),
                    ApprovingOrganizationUserId = table.Column<int>(nullable: true),
                    GeneralManagerVoteDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ApprovingOrganizationVoteDateTime = table.Column<DateTimeOffset>(nullable: true),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                    table.PrimaryKey("PK_EnergyConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyConsumptions_Users_ApprovingOrganizationUserId",
                        column: x => x.ApprovingOrganizationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnergyConsumptions_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnergyConsumptions_Users_GeneralManagerUserId",
                        column: x => x.GeneralManagerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasCityOrVillageWater = table.Column<bool>(nullable: false),
                    CvSupplySourceLocationName = table.Column<string>(nullable: true),
                    CvSpringAverageConsumption = table.Column<int>(nullable: true),
                    CvSummerAverageConsumption = table.Column<int>(nullable: true),
                    CvAutumnAverageConsumption = table.Column<int>(nullable: true),
                    CvWinterAverageConsumption = table.Column<int>(nullable: true),
                    HasGroundWater = table.Column<bool>(nullable: false),
                    GwSupplySourceLocationName = table.Column<string>(nullable: true),
                    GwSpringAverageConsumption = table.Column<int>(nullable: true),
                    GwSummerAverageConsumption = table.Column<int>(nullable: true),
                    GwAutumnAverageConsumption = table.Column<int>(nullable: true),
                    GwWinterAverageConsumption = table.Column<int>(nullable: true),
                    HasSurfaceWater = table.Column<bool>(nullable: false),
                    SwSupplySourceLocationName = table.Column<string>(nullable: true),
                    SwSpringAverageConsumption = table.Column<int>(nullable: true),
                    SwSummerAverageConsumption = table.Column<int>(nullable: true),
                    SwAutumnAverageConsumption = table.Column<int>(nullable: true),
                    SwWinterAverageConsumption = table.Column<int>(nullable: true),
                    HasSeaWater = table.Column<bool>(nullable: false),
                    SeawSupplySourceLocationName = table.Column<string>(nullable: true),
                    SeawSpringAverageConsumption = table.Column<int>(nullable: true),
                    SeawSummerAverageConsumption = table.Column<int>(nullable: true),
                    SeawAutumnAverageConsumption = table.Column<int>(nullable: true),
                    SeawWinterAverageConsumption = table.Column<int>(nullable: true),
                    CwConsumptionPlacesIds = table.Column<string>(nullable: true),
                    GwConsumptionPlacesIds = table.Column<string>(nullable: true),
                    SwConsumptionPlacesIds = table.Column<string>(nullable: true),
                    SeawConsumptionPlacesIds = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false, defaultValue: 1380),
                    GeneralManagerVote = table.Column<bool>(nullable: true),
                    GeneralManagerDescription = table.Column<string>(nullable: true),
                    GeneralManagerUserId = table.Column<int>(nullable: true),
                    ApprovingOrganizationVote = table.Column<bool>(nullable: true),
                    ApprovingOrganizationDescription = table.Column<string>(nullable: true),
                    ApprovingOrganizationUserId = table.Column<int>(nullable: true),
                    GeneralManagerVoteDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ApprovingOrganizationVoteDateTime = table.Column<DateTimeOffset>(nullable: true),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                    table.PrimaryKey("PK_WaterConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterConsumptions_Users_ApprovingOrganizationUserId",
                        column: x => x.ApprovingOrganizationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterConsumptions_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterConsumptions_Users_GeneralManagerUserId",
                        column: x => x.GeneralManagerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterConsumptions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnergyConsumptions_ApprovingOrganizationUserId",
                table: "EnergyConsumptions",
                column: "ApprovingOrganizationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyConsumptions_DocumentFileNameId",
                table: "EnergyConsumptions",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyConsumptions_GeneralManagerUserId",
                table: "EnergyConsumptions",
                column: "GeneralManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyConsumptions_IndustryId",
                table: "EnergyConsumptions",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterConsumptions_ApprovingOrganizationUserId",
                table: "WaterConsumptions",
                column: "ApprovingOrganizationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterConsumptions_DocumentFileNameId",
                table: "WaterConsumptions",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterConsumptions_GeneralManagerUserId",
                table: "WaterConsumptions",
                column: "GeneralManagerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterConsumptions_IndustryId",
                table: "WaterConsumptions",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyConsumptions");

            migrationBuilder.DropTable(
                name: "WaterConsumptions");
        }
    }
}
