using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddSitesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BirdsSites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersianName = table.Column<string>(maxLength: 300, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 300, nullable: true),
                    ProvinceId = table.Column<int>(nullable: false),
                    QuadrupleAreaId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_BirdsSites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdsSites_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirdsSites_EnumData_QuadrupleAreaId",
                        column: x => x.QuadrupleAreaId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MammalsSites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersianName = table.Column<string>(maxLength: 300, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 300, nullable: true),
                    ProvinceId = table.Column<int>(nullable: false),
                    QuadrupleAreaId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_MammalsSites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MammalsSites_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MammalsSites_EnumData_QuadrupleAreaId",
                        column: x => x.QuadrupleAreaId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BirdsSites_ProvinceId",
                table: "BirdsSites",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdsSites_QuadrupleAreaId",
                table: "BirdsSites",
                column: "QuadrupleAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsSites_ProvinceId",
                table: "MammalsSites",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_MammalsSites_QuadrupleAreaId",
                table: "MammalsSites",
                column: "QuadrupleAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirdsSites");

            migrationBuilder.DropTable(
                name: "MammalsSites");
        }
    }
}
