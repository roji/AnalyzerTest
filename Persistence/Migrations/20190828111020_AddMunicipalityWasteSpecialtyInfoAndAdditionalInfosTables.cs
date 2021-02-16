using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMunicipalityWasteSpecialtyInfoAndAdditionalInfosTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MunicipalityWasteSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeperatedDryNormalWasteDailyCollection = table.Column<int>(nullable: true),
                    SeperatedWetNormalWasteDailyCollection = table.Column<int>(nullable: true),
                    NotSeperatedNormalWasteDailyCollection = table.Column<int>(nullable: true),
                    SafeMedicalWasteDailyCollection = table.Column<int>(nullable: true),
                    CollectingUnsafeMedicalWaste = table.Column<bool>(nullable: true),
                    UnsafeMedicalWasteDailyCollection = table.Column<int>(nullable: true),
                    BuildingConstructionWasteDailyCollection = table.Column<int>(nullable: true),
                    CoveringAreasRecyclingBoothQuantity = table.Column<int>(nullable: true),
                    CoveringAreasStationedStorage = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_MunicipalityWasteSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MunicipalityWasteSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MunicipalityWasteSpecialtyAdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MunicipalityWasteSpecialtyInfoId = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
                    DailySendingAverage = table.Column<int>(nullable: true),
                    Distance = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_MunicipalityWasteSpecialtyAdditionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MunicipalityWasteSpecialtyAdditionalInfos_Industries_Industr~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MunicipalityWasteSpecialtyAdditionalInfos_MunicipalityWasteS~",
                        column: x => x.MunicipalityWasteSpecialtyInfoId,
                        principalTable: "MunicipalityWasteSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MunicipalityWasteSpecialtyAdditionalInfos_IndustryId",
                table: "MunicipalityWasteSpecialtyAdditionalInfos",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_MunicipalityWasteSpecialtyAdditionalInfos_MunicipalityWasteS~",
                table: "MunicipalityWasteSpecialtyAdditionalInfos",
                column: "MunicipalityWasteSpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MunicipalityWasteSpecialtyInfos_IndustryId",
                table: "MunicipalityWasteSpecialtyInfos",
                column: "IndustryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MunicipalityWasteSpecialtyAdditionalInfos");

            migrationBuilder.DropTable(
                name: "MunicipalityWasteSpecialtyInfos");
        }
    }
}
