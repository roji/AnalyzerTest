using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddConventionChemicalAndMixtureTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConventionChemicals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    FarsiName = table.Column<string>(nullable: true),
                    EnglishName = table.Column<string>(nullable: true),
                    CasNumber = table.Column<string>(nullable: true),
                    HsCodeId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_ConventionChemicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConventionChemicals_EnumData_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConventionChemicals_EnumData_GroupId",
                        column: x => x.GroupId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConventionChemicals_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConventionChemicalHsCodeMixtures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConventionChemicalId = table.Column<int>(nullable: false),
                    HsCodeId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ConventionChemicalHsCodeMixtures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConventionChemicalHsCodeMixtures_ConventionChemicals_Convent~",
                        column: x => x.ConventionChemicalId,
                        principalTable: "ConventionChemicals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConventionChemicalHsCodeMixtures_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConventionChemicalHsCodeMixtures_ConventionChemicalId",
                table: "ConventionChemicalHsCodeMixtures",
                column: "ConventionChemicalId");

            migrationBuilder.CreateIndex(
                name: "IX_ConventionChemicalHsCodeMixtures_HsCodeId",
                table: "ConventionChemicalHsCodeMixtures",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConventionChemicals_AttachmentId",
                table: "ConventionChemicals",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ConventionChemicals_GroupId",
                table: "ConventionChemicals",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ConventionChemicals_HsCodeId",
                table: "ConventionChemicals",
                column: "HsCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropTable(
                name: "ConventionChemicals");
        }
    }
}
