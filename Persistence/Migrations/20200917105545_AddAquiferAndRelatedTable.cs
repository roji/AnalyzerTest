using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAquiferAndRelatedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aquifers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 350, nullable: false),
                    MainBasinId = table.Column<int>(nullable: true),
                    SecondaryBasinId = table.Column<int>(nullable: true),
                    StudyAreaId = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ElectricalConductivityAverage = table.Column<double>(nullable: true),
                    UndergroundWaterLevelAverage = table.Column<double>(nullable: true),
                    WaterLevelDepth = table.Column<double>(nullable: true),
                    HydraulicSlope = table.Column<double>(nullable: true),
                    ExistenceOfAquiferSchemes = table.Column<string>(nullable: true),
                    ExistenceOfWaterResources = table.Column<string>(nullable: true),
                    OccurrenceOfSubsidenceAndRift = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Aquifers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aquifers_EnumData_MainBasinId",
                        column: x => x.MainBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aquifers_EnumData_SecondaryBasinId",
                        column: x => x.SecondaryBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aquifers_EnumData_StudyAreaId",
                        column: x => x.StudyAreaId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AquiferProvinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProvinceId = table.Column<int>(nullable: false),
                    AquiferId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AquiferProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AquiferProvinces_Aquifers_AquiferId",
                        column: x => x.AquiferId,
                        principalTable: "Aquifers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AquiferProvinces_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AquiferProvinces_AquiferId",
                table: "AquiferProvinces",
                column: "AquiferId");

            migrationBuilder.CreateIndex(
                name: "IX_AquiferProvinces_ProvinceId",
                table: "AquiferProvinces",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Aquifers_MainBasinId",
                table: "Aquifers",
                column: "MainBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_Aquifers_SecondaryBasinId",
                table: "Aquifers",
                column: "SecondaryBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_Aquifers_StudyAreaId",
                table: "Aquifers",
                column: "StudyAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AquiferProvinces");

            migrationBuilder.DropTable(
                name: "Aquifers");
        }
    }
}
