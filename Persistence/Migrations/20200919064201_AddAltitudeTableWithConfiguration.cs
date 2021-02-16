using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAltitudeTableWithConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Altitudes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 350, nullable: false),
                    AquiferId = table.Column<int>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    AltitudeTypeId = table.Column<int>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    Elevation = table.Column<double>(nullable: true),
                    PlantDescription = table.Column<string>(nullable: true),
                    RainfallAnnualAverage = table.Column<double>(nullable: true),
                    EvaporationAnnualAverage = table.Column<double>(nullable: true),
                    UnauthorizedBlockedWellsQuantity = table.Column<double>(nullable: true),
                    UnauthorizedBlockedWellsVolume = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_Altitudes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Altitudes_EnumData_AltitudeTypeId",
                        column: x => x.AltitudeTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Altitudes_Aquifers_AquiferId",
                        column: x => x.AquiferId,
                        principalTable: "Aquifers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Altitudes_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Altitudes_AltitudeTypeId",
                table: "Altitudes",
                column: "AltitudeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Altitudes_AquiferId",
                table: "Altitudes",
                column: "AquiferId");

            migrationBuilder.CreateIndex(
                name: "IX_Altitudes_ProvinceId",
                table: "Altitudes",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Altitudes");
        }
    }
}
