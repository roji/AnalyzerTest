using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFountainTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fountains",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 350, nullable: false),
                    PlainId = table.Column<int>(nullable: true),
                    AltitudeId = table.Column<int>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    FountainTypeId = table.Column<int>(nullable: true),
                    FountainWaterSourceStabilityTypeId = table.Column<int>(nullable: true),
                    ExitVolumeMonthlyAverage = table.Column<double>(nullable: true),
                    ConsumingVolumeMonthlyAverage = table.Column<double>(nullable: true),
                    Consumers = table.Column<string>(nullable: true),
                    VisualSpecification = table.Column<string>(nullable: true),
                    HasConsumptionMeter = table.Column<bool>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Fountains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fountains_Altitudes_AltitudeId",
                        column: x => x.AltitudeId,
                        principalTable: "Altitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fountains_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fountains_EnumData_FountainTypeId",
                        column: x => x.FountainTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fountains_EnumData_FountainWaterSourceStabilityTypeId",
                        column: x => x.FountainWaterSourceStabilityTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fountains_Plains_PlainId",
                        column: x => x.PlainId,
                        principalTable: "Plains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fountains_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fountains_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FountainWaterUsages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FountainId = table.Column<int>(nullable: false),
                    WaterUsageId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_FountainWaterUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FountainWaterUsages_Fountains_FountainId",
                        column: x => x.FountainId,
                        principalTable: "Fountains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FountainWaterUsages_EnumData_WaterUsageId",
                        column: x => x.WaterUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_AltitudeId",
                table: "Fountains",
                column: "AltitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_CityId",
                table: "Fountains",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_FountainTypeId",
                table: "Fountains",
                column: "FountainTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_FountainWaterSourceStabilityTypeId",
                table: "Fountains",
                column: "FountainWaterSourceStabilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_PlainId",
                table: "Fountains",
                column: "PlainId");

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_ProvinceId",
                table: "Fountains",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Fountains_StateId",
                table: "Fountains",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_FountainWaterUsages_FountainId",
                table: "FountainWaterUsages",
                column: "FountainId");

            migrationBuilder.CreateIndex(
                name: "IX_FountainWaterUsages_WaterUsageId",
                table: "FountainWaterUsages",
                column: "WaterUsageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FountainWaterUsages");

            migrationBuilder.DropTable(
                name: "Fountains");
        }
    }
}
