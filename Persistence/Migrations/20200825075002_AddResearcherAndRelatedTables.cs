using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddResearcherAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Researchers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkplaceName = table.Column<string>(nullable: true),
                    WorkplaceAddress = table.Column<string>(nullable: true),
                    WorkplacePhone = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Researchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Researchers_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Researcher_Addresses",
                columns: table => new
                {
                    ResearcherId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    AddressDetails = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researcher_Addresses", x => x.ResearcherId);
                    table.ForeignKey(
                        name: "FK_Researcher_Addresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Researcher_Addresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Researcher_Addresses_Researchers_ResearcherId",
                        column: x => x.ResearcherId,
                        principalTable: "Researchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Researcher_Addresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Researcher_Information",
                columns: table => new
                {
                    ResearcherId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SurvivalStatus = table.Column<bool>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    Faith = table.Column<string>(nullable: true),
                    GradeId = table.Column<int>(nullable: true),
                    MaritalStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researcher_Information", x => x.ResearcherId);
                    table.ForeignKey(
                        name: "FK_Researcher_Information_EnumData_GradeId",
                        column: x => x.GradeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Researcher_Information_EnumData_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Researcher_Information_Researchers_ResearcherId",
                        column: x => x.ResearcherId,
                        principalTable: "Researchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResearcherForeignLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ForeignLanguageId = table.Column<int>(nullable: false),
                    ResearcherId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ResearcherForeignLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearcherForeignLanguages_EnumData_ForeignLanguageId",
                        column: x => x.ForeignLanguageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearcherForeignLanguages_Researchers_ResearcherId",
                        column: x => x.ResearcherId,
                        principalTable: "Researchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Researcher_Addresses_CityId",
                table: "Researcher_Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Researcher_Addresses_ProvinceId",
                table: "Researcher_Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Researcher_Addresses_StateId",
                table: "Researcher_Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Researcher_Information_GradeId",
                table: "Researcher_Information",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Researcher_Information_ReligionId",
                table: "Researcher_Information",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearcherForeignLanguages_ForeignLanguageId",
                table: "ResearcherForeignLanguages",
                column: "ForeignLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearcherForeignLanguages_ResearcherId",
                table: "ResearcherForeignLanguages",
                column: "ResearcherId");

            migrationBuilder.CreateIndex(
                name: "IX_Researchers_PhotoFileNameId",
                table: "Researchers",
                column: "PhotoFileNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Researcher_Addresses");

            migrationBuilder.DropTable(
                name: "Researcher_Information");

            migrationBuilder.DropTable(
                name: "ResearcherForeignLanguages");

            migrationBuilder.DropTable(
                name: "Researchers");
        }
    }
}
