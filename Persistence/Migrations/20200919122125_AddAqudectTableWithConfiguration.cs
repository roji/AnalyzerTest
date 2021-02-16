using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAqudectTableWithConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aqueducts",
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
                    AqueductTypeId = table.Column<int>(nullable: true),
                    AqueductWaterSourceStabilityTypeId = table.Column<int>(nullable: true),
                    WaterUsageId = table.Column<int>(nullable: true),
                    ExitVolumeDailyAverage = table.Column<double>(nullable: true),
                    ConsumingVolumeMonthlyAverage = table.Column<double>(nullable: true),
                    Consumers = table.Column<string>(nullable: true),
                    VisualSpecification = table.Column<string>(nullable: true),
                    HasConsumptionMeter = table.Column<bool>(nullable: true),
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
                    table.PrimaryKey("PK_Aqueducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aqueducts_Altitudes_AltitudeId",
                        column: x => x.AltitudeId,
                        principalTable: "Altitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_EnumData_AqueductTypeId",
                        column: x => x.AqueductTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_EnumData_AqueductWaterSourceStabilityTypeId",
                        column: x => x.AqueductWaterSourceStabilityTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_Plains_PlainId",
                        column: x => x.PlainId,
                        principalTable: "Plains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aqueducts_EnumData_WaterUsageId",
                        column: x => x.WaterUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AqueductWells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AqueductId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(maxLength: 50, nullable: false),
                    Longitude = table.Column<string>(maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_AqueductWells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AqueductWells_Aqueducts_AqueductId",
                        column: x => x.AqueductId,
                        principalTable: "Aqueducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_AltitudeId",
                table: "Aqueducts",
                column: "AltitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_AqueductTypeId",
                table: "Aqueducts",
                column: "AqueductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_AqueductWaterSourceStabilityTypeId",
                table: "Aqueducts",
                column: "AqueductWaterSourceStabilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_CityId",
                table: "Aqueducts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_PlainId",
                table: "Aqueducts",
                column: "PlainId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_ProvinceId",
                table: "Aqueducts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_StateId",
                table: "Aqueducts",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Aqueducts_WaterUsageId",
                table: "Aqueducts",
                column: "WaterUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_AqueductWells_AqueductId",
                table: "AqueductWells",
                column: "AqueductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AqueductWells");

            migrationBuilder.DropTable(
                name: "Aqueducts");
        }
    }
}
