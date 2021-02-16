using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAnimalMusuemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersianName = table.Column<string>(maxLength: 255, nullable: true),
                    EnglishName = table.Column<string>(maxLength: 255, nullable: true),
                    Repeats = table.Column<int>(nullable: true),
                    OldSampleCode = table.Column<string>(nullable: true),
                    NewSampleCode = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Elevation = table.Column<string>(nullable: true),
                    LocationMaximumAltitude = table.Column<double>(nullable: true),
                    LocationMinimumAltitude = table.Column<double>(nullable: true),
                    LocationAccuracyId = table.Column<int>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    AnimalProtectedZoneId = table.Column<int>(nullable: true),
                    AnimalLocationId = table.Column<int>(nullable: true),
                    AnimalKingdomId = table.Column<int>(nullable: true),
                    AnimalPhylumId = table.Column<int>(nullable: true),
                    AnimalClassId = table.Column<int>(nullable: true),
                    AnimalOrderId = table.Column<int>(nullable: true),
                    AnimalFamilyId = table.Column<int>(nullable: true),
                    AnimalGenusId = table.Column<int>(nullable: true),
                    AnimalSpeciesId = table.Column<int>(nullable: true),
                    AnimalSubSpeciesId = table.Column<int>(nullable: true),
                    AnimalTypeId = table.Column<int>(nullable: true),
                    AnimalEcosystemId = table.Column<int>(nullable: true),
                    AnimalPreservationId = table.Column<int>(nullable: true),
                    AnimalConservationStatusId = table.Column<int>(nullable: true),
                    CollectorPersianName = table.Column<string>(nullable: true),
                    CollectorEnglishName = table.Column<string>(nullable: true),
                    DeterminatorPersianName = table.Column<string>(nullable: true),
                    DeterminatorEnglishName = table.Column<string>(nullable: true),
                    RevisionistPersianName = table.Column<string>(nullable: true),
                    RevisionistEnglishName = table.Column<string>(nullable: true),
                    TaxidermistPersianName = table.Column<string>(nullable: true),
                    TaxidermistEnglishName = table.Column<string>(nullable: true),
                    DescriptivePersianName = table.Column<string>(nullable: true),
                    DescriptiveEnglishName = table.Column<string>(nullable: true),
                    RevisionDate = table.Column<int>(nullable: true),
                    BiometricInformation = table.Column<string>(nullable: true),
                    PreservationMethod = table.Column<string>(nullable: true),
                    IsNative = table.Column<bool>(nullable: true),
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
                    table.PrimaryKey("PK_AnimalMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalClassId",
                        column: x => x.AnimalClassId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalConservationStatusId",
                        column: x => x.AnimalConservationStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalEcosystemId",
                        column: x => x.AnimalEcosystemId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalFamilyId",
                        column: x => x.AnimalFamilyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalGenusId",
                        column: x => x.AnimalGenusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalKingdomId",
                        column: x => x.AnimalKingdomId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalLocationId",
                        column: x => x.AnimalLocationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalOrderId",
                        column: x => x.AnimalOrderId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalPhylumId",
                        column: x => x.AnimalPhylumId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalPreservationId",
                        column: x => x.AnimalPreservationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalProtectedZoneId",
                        column: x => x.AnimalProtectedZoneId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalSpeciesId",
                        column: x => x.AnimalSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalSubSpeciesId",
                        column: x => x.AnimalSubSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_AnimalTypeId",
                        column: x => x.AnimalTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_LocationAccuracyId",
                        column: x => x.LocationAccuracyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMuseums_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalClassId",
                table: "AnimalMuseums",
                column: "AnimalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalConservationStatusId",
                table: "AnimalMuseums",
                column: "AnimalConservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalEcosystemId",
                table: "AnimalMuseums",
                column: "AnimalEcosystemId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalFamilyId",
                table: "AnimalMuseums",
                column: "AnimalFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalGenusId",
                table: "AnimalMuseums",
                column: "AnimalGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalKingdomId",
                table: "AnimalMuseums",
                column: "AnimalKingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalLocationId",
                table: "AnimalMuseums",
                column: "AnimalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalOrderId",
                table: "AnimalMuseums",
                column: "AnimalOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalPhylumId",
                table: "AnimalMuseums",
                column: "AnimalPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalPreservationId",
                table: "AnimalMuseums",
                column: "AnimalPreservationId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalProtectedZoneId",
                table: "AnimalMuseums",
                column: "AnimalProtectedZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalSpeciesId",
                table: "AnimalMuseums",
                column: "AnimalSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalSubSpeciesId",
                table: "AnimalMuseums",
                column: "AnimalSubSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_AnimalTypeId",
                table: "AnimalMuseums",
                column: "AnimalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_LocationAccuracyId",
                table: "AnimalMuseums",
                column: "LocationAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_PhotoFileNameId",
                table: "AnimalMuseums",
                column: "PhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMuseums_ProvinceId",
                table: "AnimalMuseums",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalMuseums");
        }
    }
}
