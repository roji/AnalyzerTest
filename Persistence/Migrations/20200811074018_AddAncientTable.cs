using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAncientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AncientMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SiteNumber = table.Column<string>(nullable: true),
                    UsingReference = table.Column<string>(nullable: true),
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
                    AncientProtectedZoneId = table.Column<int>(nullable: true),
                    AncientLocationId = table.Column<int>(nullable: true),
                    AncientKingdomId = table.Column<int>(nullable: true),
                    AncientPhylumId = table.Column<int>(nullable: true),
                    AncientClassId = table.Column<int>(nullable: true),
                    AncientOrderId = table.Column<int>(nullable: true),
                    AncientFamilyId1 = table.Column<int>(nullable: true),
                    AncientFamilyId = table.Column<int>(nullable: true),
                    AncientSubFamilyId = table.Column<int>(nullable: true),
                    AncientGenusId = table.Column<int>(nullable: true),
                    AncientSpeciesId = table.Column<int>(nullable: true),
                    AncientTypeId = table.Column<int>(nullable: true),
                    AncientAgeId = table.Column<int>(nullable: true),
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
                    HasForeignSample = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_AncientMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientAgeId",
                        column: x => x.AncientAgeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientClassId",
                        column: x => x.AncientClassId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientFamilyId",
                        column: x => x.AncientFamilyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientFamilyId1",
                        column: x => x.AncientFamilyId1,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientGenusId",
                        column: x => x.AncientGenusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientKingdomId",
                        column: x => x.AncientKingdomId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientLocationId",
                        column: x => x.AncientLocationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientOrderId",
                        column: x => x.AncientOrderId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientPhylumId",
                        column: x => x.AncientPhylumId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientProtectedZoneId",
                        column: x => x.AncientProtectedZoneId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientSpeciesId",
                        column: x => x.AncientSpeciesId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_AncientTypeId",
                        column: x => x.AncientTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_LocationAccuracyId",
                        column: x => x.LocationAccuracyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AncientMuseums_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientAgeId",
                table: "AncientMuseums",
                column: "AncientAgeId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientClassId",
                table: "AncientMuseums",
                column: "AncientClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientFamilyId",
                table: "AncientMuseums",
                column: "AncientFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientFamilyId1",
                table: "AncientMuseums",
                column: "AncientFamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientGenusId",
                table: "AncientMuseums",
                column: "AncientGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientKingdomId",
                table: "AncientMuseums",
                column: "AncientKingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientLocationId",
                table: "AncientMuseums",
                column: "AncientLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientOrderId",
                table: "AncientMuseums",
                column: "AncientOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientPhylumId",
                table: "AncientMuseums",
                column: "AncientPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientProtectedZoneId",
                table: "AncientMuseums",
                column: "AncientProtectedZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientSpeciesId",
                table: "AncientMuseums",
                column: "AncientSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_AncientTypeId",
                table: "AncientMuseums",
                column: "AncientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_LocationAccuracyId",
                table: "AncientMuseums",
                column: "LocationAccuracyId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_PhotoFileNameId",
                table: "AncientMuseums",
                column: "PhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_AncientMuseums_ProvinceId",
                table: "AncientMuseums",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AncientMuseums");
        }
    }
}
