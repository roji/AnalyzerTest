using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMineralStoneMuseumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MineralStoneMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Repeats = table.Column<int>(nullable: true),
                    OldSampleCode = table.Column<string>(nullable: true),
                    NewSampleCode = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Elevation = table.Column<string>(nullable: true),
                    LocationMaximumAltitude = table.Column<double>(nullable: true),
                    LocationMinimumAltitude = table.Column<double>(nullable: true),
                    CollectingDate = table.Column<int>(nullable: true),
                    LocationAccuracyId = table.Column<int>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    MineralStoneProtectedZoneId = table.Column<int>(nullable: true),
                    MineralStoneLocationId = table.Column<int>(nullable: true),
                    MineralStoneMineralTypeId = table.Column<int>(nullable: true),
                    MineralStoneStoneTypeId = table.Column<int>(nullable: true),
                    MineralStoneHardnessId = table.Column<int>(nullable: true),
                    MineralStoneCrystallizationSystemId = table.Column<int>(nullable: true),
                    CollectorPersianName = table.Column<string>(nullable: true),
                    CollectorEnglishName = table.Column<string>(nullable: true),
                    DeterminatorPersianName = table.Column<string>(nullable: true),
                    DeterminatorEnglishName = table.Column<string>(nullable: true),
                    RevisionistPersianName = table.Column<string>(nullable: true),
                    RevisionistEnglishName = table.Column<string>(nullable: true),
                    RevisionDate = table.Column<int>(nullable: true),
                    DonatorPersianName = table.Column<string>(nullable: true),
                    DonatorEnglishName = table.Column<string>(nullable: true),
                    DonateDate = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    PhotoFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                    table.PrimaryKey("PK_MineralStoneMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_LocationAccuracyId",
                        column: x => x.LocationAccuracyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_MineralStoneCrystallizationSyst~",
                        column: x => x.MineralStoneCrystallizationSystemId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_MineralStoneHardnessId",
                        column: x => x.MineralStoneHardnessId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_MineralStoneLocationId",
                        column: x => x.MineralStoneLocationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_MineralStoneMineralTypeId",
                        column: x => x.MineralStoneMineralTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_MineralStoneProtectedZoneId",
                        column: x => x.MineralStoneProtectedZoneId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_MineralStoneStoneTypeId",
                        column: x => x.MineralStoneStoneTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineralStoneMuseums_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_LocationAccuracyId",
                table: "MineralStoneMuseums",
                column: "LocationAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_MineralStoneCrystallizationSystemId",
                table: "MineralStoneMuseums",
                column: "MineralStoneCrystallizationSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_MineralStoneHardnessId",
                table: "MineralStoneMuseums",
                column: "MineralStoneHardnessId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_MineralStoneLocationId",
                table: "MineralStoneMuseums",
                column: "MineralStoneLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_MineralStoneMineralTypeId",
                table: "MineralStoneMuseums",
                column: "MineralStoneMineralTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_MineralStoneProtectedZoneId",
                table: "MineralStoneMuseums",
                column: "MineralStoneProtectedZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_MineralStoneStoneTypeId",
                table: "MineralStoneMuseums",
                column: "MineralStoneStoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_PhotoFileNameId",
                table: "MineralStoneMuseums",
                column: "PhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralStoneMuseums_ProvinceId",
                table: "MineralStoneMuseums",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MineralStoneMuseums");
        }
    }
}
