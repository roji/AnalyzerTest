using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMammalsCensusAndRelatedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MammalsCensuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<int>(nullable: false),
                    Offers = table.Column<string>(nullable: true),
                    OperationalStrengths = table.Column<string>(nullable: true),
                    OperationalWeaknesses = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_MammalsCensuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MammalsCensuses_Uploads_RationalTopographyMapFileNameId",
                        column: x => x.RationalTopographyMapFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MammalsCensusPersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MammalsCensusId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MammalsCensusPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MammalsCensusPersons_MammalsCensuses_MammalsCensusId",
                        column: x => x.MammalsCensusId,
                        principalTable: "MammalsCensuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MammalsCensusSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MammalsCensusId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(nullable: true),
                    SpecieId = table.Column<int>(nullable: false),
                    MatureMaleUnderFiveYearsOldQuantity = table.Column<int>(nullable: false),
                    MatureMaleOverFiveYearsOldQuantity = table.Column<int>(nullable: false),
                    MatureFemaleQuantity = table.Column<int>(nullable: false),
                    ImmatureQuantity = table.Column<int>(nullable: false),
                    UnknownQuantity = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MammalsCensusSpecies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MammalsCensusSpecies_MammalsCensuses_MammalsCensusId",
                        column: x => x.MammalsCensusId,
                        principalTable: "MammalsCensuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MammalsCensusSpecies_MammalsSites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "MammalsSites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MammalsCensusSpecies_EnumData_SpecieId",
                        column: x => x.SpecieId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensuses_FinalSave",
                table: "MammalsCensuses",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensuses_RationalTopographyMapFileNameId",
                table: "MammalsCensuses",
                column: "RationalTopographyMapFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensusPersons_MammalsCensusId",
                table: "MammalsCensusPersons",
                column: "MammalsCensusId");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensusSpecies_MammalsCensusId",
                table: "MammalsCensusSpecies",
                column: "MammalsCensusId");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensusSpecies_SiteId",
                table: "MammalsCensusSpecies",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensusSpecies_SpecieId",
                table: "MammalsCensusSpecies",
                column: "SpecieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MammalsCensusPersons");

            migrationBuilder.DropTable(
                name: "MammalsCensusSpecies");

            migrationBuilder.DropTable(
                name: "MammalsCensuses");
        }
    }
}
