using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddGeneticsMusuemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneticsMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalPersianName = table.Column<string>(maxLength: 255, nullable: true),
                    PlantPersianName = table.Column<string>(maxLength: 255, nullable: true),
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
                    GeneticsProtectedZoneId = table.Column<int>(nullable: true),
                    GeneticsLocationId = table.Column<int>(nullable: true),
                    GeneticsKingdomId = table.Column<int>(nullable: true),
                    GeneticsPhylumId = table.Column<int>(nullable: true),
                    GeneticsClassId = table.Column<int>(nullable: true),
                    GeneticsOrderId = table.Column<int>(nullable: true),
                    GeneticsFamilyId = table.Column<int>(nullable: true),
                    GeneticsGenusId = table.Column<int>(nullable: true),
                    GeneticsSpeciesId = table.Column<int>(nullable: true),
                    GeneticsSubSpeciesId = table.Column<int>(nullable: true),
                    GeneticsVarietyId = table.Column<int>(nullable: true),
                    GeneticsTypeId = table.Column<int>(nullable: true),
                    GeneticsSpecimenTypeId = table.Column<int>(nullable: true),
                    GeneticsQualityId = table.Column<int>(nullable: true),
                    GeneticsConservationStatusId = table.Column<int>(nullable: true),
                    CollectorPersianName = table.Column<string>(nullable: true),
                    CollectorEnglishName = table.Column<string>(nullable: true),
                    DeterminatorPersianName = table.Column<string>(nullable: true),
                    DeterminatorEnglishName = table.Column<string>(nullable: true),
                    RevisionistPersianName = table.Column<string>(nullable: true),
                    RevisionistEnglishName = table.Column<string>(nullable: true),
                    RevisionDate = table.Column<int>(nullable: true),
                    PreservationMethod = table.Column<string>(nullable: true),
                    Ambiguous = table.Column<string>(nullable: true),
                    IsMale = table.Column<bool>(nullable: true),
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
                    table.PrimaryKey("PK_GeneticsMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsClassId",
                        column: x => x.GeneticsClassId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsConservationStatusId",
                        column: x => x.GeneticsConservationStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsFamilyId",
                        column: x => x.GeneticsFamilyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsGenusId",
                        column: x => x.GeneticsGenusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsKingdomId",
                        column: x => x.GeneticsKingdomId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsLocationId",
                        column: x => x.GeneticsLocationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsOrderId",
                        column: x => x.GeneticsOrderId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsPhylumId",
                        column: x => x.GeneticsPhylumId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsProtectedZoneId",
                        column: x => x.GeneticsProtectedZoneId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsQualityId",
                        column: x => x.GeneticsQualityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsSpeciesId",
                        column: x => x.GeneticsSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsSpecimenTypeId",
                        column: x => x.GeneticsSpecimenTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsSubSpeciesId",
                        column: x => x.GeneticsSubSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsTypeId",
                        column: x => x.GeneticsTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_GeneticsVarietyId",
                        column: x => x.GeneticsVarietyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_LocationAccuracyId",
                        column: x => x.LocationAccuracyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneticsMuseums_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsClassId",
                table: "GeneticsMuseums",
                column: "GeneticsClassId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsConservationStatusId",
                table: "GeneticsMuseums",
                column: "GeneticsConservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsFamilyId",
                table: "GeneticsMuseums",
                column: "GeneticsFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsGenusId",
                table: "GeneticsMuseums",
                column: "GeneticsGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsKingdomId",
                table: "GeneticsMuseums",
                column: "GeneticsKingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsLocationId",
                table: "GeneticsMuseums",
                column: "GeneticsLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsOrderId",
                table: "GeneticsMuseums",
                column: "GeneticsOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsPhylumId",
                table: "GeneticsMuseums",
                column: "GeneticsPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsProtectedZoneId",
                table: "GeneticsMuseums",
                column: "GeneticsProtectedZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsQualityId",
                table: "GeneticsMuseums",
                column: "GeneticsQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsSpeciesId",
                table: "GeneticsMuseums",
                column: "GeneticsSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsSpecimenTypeId",
                table: "GeneticsMuseums",
                column: "GeneticsSpecimenTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsSubSpeciesId",
                table: "GeneticsMuseums",
                column: "GeneticsSubSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsTypeId",
                table: "GeneticsMuseums",
                column: "GeneticsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_GeneticsVarietyId",
                table: "GeneticsMuseums",
                column: "GeneticsVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_LocationAccuracyId",
                table: "GeneticsMuseums",
                column: "LocationAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_PhotoFileNameId",
                table: "GeneticsMuseums",
                column: "PhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneticsMuseums_ProvinceId",
                table: "GeneticsMuseums",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneticsMuseums");
        }
    }
}
