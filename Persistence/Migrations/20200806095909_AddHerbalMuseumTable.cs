using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHerbalMuseumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HerbalMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlantName = table.Column<string>(maxLength: 255, nullable: true),
                    Repeats = table.Column<int>(nullable: true),
                    OldSampleCode = table.Column<string>(nullable: true),
                    NewSampleCode = table.Column<string>(nullable: true),
                    CollectingDate = table.Column<int>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Elevation = table.Column<string>(nullable: true),
                    LocationMaximumAltitude = table.Column<double>(nullable: true),
                    LocationMinimumAltitude = table.Column<double>(nullable: true),
                    HasForeignSample = table.Column<bool>(nullable: false),
                    LocationAccuracyId = table.Column<int>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    HerbalProtectedZoneId = table.Column<int>(nullable: true),
                    HerbalLocationId = table.Column<int>(nullable: true),
                    HerbalKingdomId = table.Column<int>(nullable: true),
                    HerbalPhylumId = table.Column<int>(nullable: true),
                    HerbalClassId = table.Column<int>(nullable: true),
                    HerbalOrderId = table.Column<int>(nullable: true),
                    HerbalFamilyId = table.Column<int>(nullable: true),
                    HerbalGenusId = table.Column<int>(nullable: true),
                    HerbalSpeciesId = table.Column<int>(nullable: true),
                    HerbalSubSpeciesId = table.Column<int>(nullable: true),
                    HerbalVarietyId = table.Column<int>(nullable: true),
                    HerbalTypeId = table.Column<int>(nullable: true),
                    HerbalEcosystemId = table.Column<int>(nullable: true),
                    HerbalTopographyId = table.Column<int>(nullable: true),
                    HerbalSoilTypeId = table.Column<int>(nullable: true),
                    HerbalLifeFormId = table.Column<int>(nullable: true),
                    HerbalChoroTypeId = table.Column<int>(nullable: true),
                    HerbalConservationStatusId = table.Column<int>(nullable: true),
                    CollectorPersianName = table.Column<string>(nullable: true),
                    CollectorEnglishName = table.Column<string>(nullable: true),
                    DeterminatorPersianName = table.Column<string>(nullable: true),
                    DeterminatorEnglishName = table.Column<string>(nullable: true),
                    RevisionistPersianName = table.Column<string>(nullable: true),
                    RevisionistEnglishName = table.Column<string>(nullable: true),
                    RevisionDate = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HerbalMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalChoroTypeId",
                        column: x => x.HerbalChoroTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalClassId",
                        column: x => x.HerbalClassId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalConservationStatusId",
                        column: x => x.HerbalConservationStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalEcosystemId",
                        column: x => x.HerbalEcosystemId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalFamilyId",
                        column: x => x.HerbalFamilyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalGenusId",
                        column: x => x.HerbalGenusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalKingdomId",
                        column: x => x.HerbalKingdomId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalLifeFormId",
                        column: x => x.HerbalLifeFormId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalLocationId",
                        column: x => x.HerbalLocationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalOrderId",
                        column: x => x.HerbalOrderId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalPhylumId",
                        column: x => x.HerbalPhylumId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalProtectedZoneId",
                        column: x => x.HerbalProtectedZoneId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalSoilTypeId",
                        column: x => x.HerbalSoilTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalSpeciesId",
                        column: x => x.HerbalSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalSubSpeciesId",
                        column: x => x.HerbalSubSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalTopographyId",
                        column: x => x.HerbalTopographyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalTypeId",
                        column: x => x.HerbalTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_HerbalVarietyId",
                        column: x => x.HerbalVarietyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_LocationAccuracyId",
                        column: x => x.LocationAccuracyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HerbalMuseums_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalChoroTypeId",
                table: "HerbalMuseums",
                column: "HerbalChoroTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalClassId",
                table: "HerbalMuseums",
                column: "HerbalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalConservationStatusId",
                table: "HerbalMuseums",
                column: "HerbalConservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalEcosystemId",
                table: "HerbalMuseums",
                column: "HerbalEcosystemId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalFamilyId",
                table: "HerbalMuseums",
                column: "HerbalFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalGenusId",
                table: "HerbalMuseums",
                column: "HerbalGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalKingdomId",
                table: "HerbalMuseums",
                column: "HerbalKingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalLifeFormId",
                table: "HerbalMuseums",
                column: "HerbalLifeFormId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalLocationId",
                table: "HerbalMuseums",
                column: "HerbalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalOrderId",
                table: "HerbalMuseums",
                column: "HerbalOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalPhylumId",
                table: "HerbalMuseums",
                column: "HerbalPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalProtectedZoneId",
                table: "HerbalMuseums",
                column: "HerbalProtectedZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalSoilTypeId",
                table: "HerbalMuseums",
                column: "HerbalSoilTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalSpeciesId",
                table: "HerbalMuseums",
                column: "HerbalSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalSubSpeciesId",
                table: "HerbalMuseums",
                column: "HerbalSubSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalTopographyId",
                table: "HerbalMuseums",
                column: "HerbalTopographyId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalTypeId",
                table: "HerbalMuseums",
                column: "HerbalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_HerbalVarietyId",
                table: "HerbalMuseums",
                column: "HerbalVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_LocationAccuracyId",
                table: "HerbalMuseums",
                column: "LocationAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_PhotoFileNameId",
                table: "HerbalMuseums",
                column: "PhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HerbalMuseums_ProvinceId",
                table: "HerbalMuseums",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HerbalMuseums");
        }
    }
}
