using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRiverProvinceRangesAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiverProvinceRanges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    RiverLengthInProvince = table.Column<double>(nullable: true),
                    DebiPerYearAverageInProvince = table.Column<double>(nullable: true),
                    OriginInProvince = table.Column<string>(nullable: true),
                    OriginLatitudeInProvince = table.Column<string>(nullable: true),
                    OriginLongitudeInProvince = table.Column<string>(nullable: true),
                    FinalSourceInProvince = table.Column<string>(nullable: true),
                    FinalSourceLatitudeInProvince = table.Column<string>(nullable: true),
                    FinalSourceLongitudeInProvince = table.Column<string>(nullable: true),
                    IsProtectedInProvince = table.Column<bool>(nullable: false),
                    DeterminedRightOfWaterAmount = table.Column<double>(nullable: true),
                    UnboundRightOfWaterAmount = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_RiverProvinceRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverProvinceRanges_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiverProvinceRanges_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiverPassingCities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverProvinceRangeId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_RiverPassingCities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPassingCities_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiverPassingCities_RiverProvinceRanges_RiverProvinceRangeId",
                        column: x => x.RiverProvinceRangeId,
                        principalTable: "RiverProvinceRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiverUsageTypesInProvinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverProvinceRangeId = table.Column<int>(nullable: false),
                    RiverUsageTypeId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_RiverUsageTypesInProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverUsageTypesInProvinces_RiverProvinceRanges_RiverProvince~",
                        column: x => x.RiverProvinceRangeId,
                        principalTable: "RiverProvinceRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverUsageTypesInProvinces_EnumData_RiverUsageTypeId",
                        column: x => x.RiverUsageTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RiverPassingCities_CityId",
                table: "RiverPassingCities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPassingCities_RiverProvinceRangeId",
                table: "RiverPassingCities",
                column: "RiverProvinceRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverProvinceRanges_ProvinceId",
                table: "RiverProvinceRanges",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverProvinceRanges_RiverId",
                table: "RiverProvinceRanges",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverUsageTypesInProvinces_RiverProvinceRangeId",
                table: "RiverUsageTypesInProvinces",
                column: "RiverProvinceRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverUsageTypesInProvinces_RiverUsageTypeId",
                table: "RiverUsageTypesInProvinces",
                column: "RiverUsageTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiverPassingCities");

            migrationBuilder.DropTable(
                name: "RiverUsageTypesInProvinces");

            migrationBuilder.DropTable(
                name: "RiverProvinceRanges");
        }
    }
}
