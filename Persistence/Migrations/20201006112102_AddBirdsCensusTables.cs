using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddBirdsCensusTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BirdsCensuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<int>(nullable: false),
                    Offers = table.Column<string>(nullable: true),
                    OperationalStrengths = table.Column<string>(nullable: true),
                    OperationalWeaknesses = table.Column<string>(nullable: true),
                    QuadrupleAreaId = table.Column<int>(nullable: false),
                    CensusArea = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RationalTopographyMapFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    FinalSave = table.Column<bool>(nullable: false, defaultValue: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
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
                    table.PrimaryKey("PK_BirdsCensuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdsCensuses_EnumData_QuadrupleAreaId",
                        column: x => x.QuadrupleAreaId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirdsCensuses_Uploads_RationalTopographyMapFileNameId",
                        column: x => x.RationalTopographyMapFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BirdsCensusPersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BirdsCensusId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 256, nullable: false),
                    Rank = table.Column<string>(maxLength: 256, nullable: false),
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
                    table.PrimaryKey("PK_BirdsCensusPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdsCensusPersons_BirdsCensuses_BirdsCensusId",
                        column: x => x.BirdsCensusId,
                        principalTable: "BirdsCensuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BirdsCensusSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BirdsCensusId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(nullable: true),
                    GenusId = table.Column<int>(nullable: false),
                    SpecieId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_BirdsCensusSpecies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdsCensusSpecies_BirdsCensuses_BirdsCensusId",
                        column: x => x.BirdsCensusId,
                        principalTable: "BirdsCensuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BirdsCensusSpecies_EnumData_GenusId",
                        column: x => x.GenusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirdsCensusSpecies_BirdsSites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "BirdsSites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirdsCensusSpecies_EnumData_SpecieId",
                        column: x => x.SpecieId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensuses_FinalSave",
                table: "BirdsCensuses",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensuses_QuadrupleAreaId",
                table: "BirdsCensuses",
                column: "QuadrupleAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensuses_RationalTopographyMapFileNameId",
                table: "BirdsCensuses",
                column: "RationalTopographyMapFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensusPersons_BirdsCensusId",
                table: "BirdsCensusPersons",
                column: "BirdsCensusId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensusSpecies_BirdsCensusId",
                table: "BirdsCensusSpecies",
                column: "BirdsCensusId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensusSpecies_GenusId",
                table: "BirdsCensusSpecies",
                column: "GenusId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensusSpecies_SiteId",
                table: "BirdsCensusSpecies",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsCensusSpecies_SpecieId",
                table: "BirdsCensusSpecies",
                column: "SpecieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirdsCensusPersons");

            migrationBuilder.DropTable(
                name: "BirdsCensusSpecies");

            migrationBuilder.DropTable(
                name: "BirdsCensuses");
        }
    }
}
