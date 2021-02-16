using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddPitsRelatedtableAndUpdateAqueductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aqueducts_EnumData_WaterUsageId",
                table: "Aqueducts");

            migrationBuilder.DropIndex(
                name: "IX_Aqueducts_WaterUsageId",
                table: "Aqueducts");

            migrationBuilder.DropColumn(
                name: "WaterUsageId",
                table: "Aqueducts");

            migrationBuilder.CreateTable(
                name: "AqueductWaterUsages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AqueductId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AqueductWaterUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AqueductWaterUsages_Aqueducts_AqueductId",
                        column: x => x.AqueductId,
                        principalTable: "Aqueducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AqueductWaterUsages_EnumData_WaterUsageId",
                        column: x => x.WaterUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 350, nullable: false),
                    HasLicense = table.Column<bool>(nullable: false),
                    LicenseNumber = table.Column<string>(nullable: true),
                    PlainId = table.Column<int>(nullable: true),
                    AltitudeId = table.Column<int>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    PitTypeId = table.Column<int>(nullable: true),
                    PitWaterSourceStabilityTypeId = table.Column<int>(nullable: true),
                    ExitVolumeDailyAverage = table.Column<double>(nullable: true),
                    ConsumingVolumeMonthlyAverage = table.Column<double>(nullable: true),
                    Consumers = table.Column<string>(nullable: true),
                    VisualSpecification = table.Column<string>(nullable: true),
                    HasConsumptionMeter = table.Column<bool>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    PitElevation = table.Column<double>(nullable: true),
                    PitDiameter = table.Column<double>(nullable: true),
                    StorageVolume = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_Pits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pits_Altitudes_AltitudeId",
                        column: x => x.AltitudeId,
                        principalTable: "Altitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pits_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pits_EnumData_PitTypeId",
                        column: x => x.PitTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pits_EnumData_PitWaterSourceStabilityTypeId",
                        column: x => x.PitWaterSourceStabilityTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pits_Plains_PlainId",
                        column: x => x.PlainId,
                        principalTable: "Plains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pits_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pits_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PitWaterUsages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PitId = table.Column<int>(nullable: false),
                    WaterUsageId = table.Column<int>(nullable: false),
                    DailyConsumingVolume = table.Column<double>(nullable: false),
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
                    table.PrimaryKey("PK_PitWaterUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PitWaterUsages_Pits_PitId",
                        column: x => x.PitId,
                        principalTable: "Pits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PitWaterUsages_EnumData_WaterUsageId",
                        column: x => x.WaterUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AqueductWaterUsages_AqueductId",
                table: "AqueductWaterUsages",
                column: "AqueductId");

            migrationBuilder.CreateIndex(
                name: "IX_AqueductWaterUsages_WaterUsageId",
                table: "AqueductWaterUsages",
                column: "WaterUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_AltitudeId",
                table: "Pits",
                column: "AltitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_CityId",
                table: "Pits",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_PitTypeId",
                table: "Pits",
                column: "PitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_PitWaterSourceStabilityTypeId",
                table: "Pits",
                column: "PitWaterSourceStabilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_PlainId",
                table: "Pits",
                column: "PlainId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_ProvinceId",
                table: "Pits",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_StateId",
                table: "Pits",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PitWaterUsages_PitId",
                table: "PitWaterUsages",
                column: "PitId");

            migrationBuilder.CreateIndex(
                name: "IX_PitWaterUsages_WaterUsageId",
                table: "PitWaterUsages",
                column: "WaterUsageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AqueductWaterUsages");

            migrationBuilder.DropTable(
                name: "PitWaterUsages");

            migrationBuilder.DropTable(
                name: "Pits");

            migrationBuilder.AddColumn<int>(
                name: "WaterUsageId",
                table: "Aqueducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_WaterUsageId",
                table: "Aqueducts",
                column: "WaterUsageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aqueducts_EnumData_WaterUsageId",
                table: "Aqueducts",
                column: "WaterUsageId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
