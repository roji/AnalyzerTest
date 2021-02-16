using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RiverAndRelatedTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    MainBasinId = table.Column<int>(nullable: false),
                    Length = table.Column<double>(nullable: true),
                    DebiPerYearAverage = table.Column<double>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    OriginLatitude = table.Column<string>(nullable: true),
                    OriginLongitude = table.Column<string>(nullable: true),
                    FinalSource = table.Column<string>(nullable: true),
                    FinalSourceLatitude = table.Column<string>(nullable: true),
                    FinalSourceLongitude = table.Column<string>(nullable: true),
                    IsInBorder = table.Column<bool>(nullable: false),
                    IsProtected = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_Rivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rivers_EnumData_MainBasinId",
                        column: x => x.MainBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiverPassingProvinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_RiverPassingProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPassingProvinces_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiverPassingProvinces_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiverSecondaryBasins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverId = table.Column<int>(nullable: false),
                    SecondaryBasinId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_RiverSecondaryBasins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverSecondaryBasins_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverSecondaryBasins_EnumData_SecondaryBasinId",
                        column: x => x.SecondaryBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiverUsageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverId = table.Column<int>(nullable: false),
                    RiverUsageTypeId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_RiverUsageTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverUsageTypes_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverUsageTypes_EnumData_RiverUsageTypeId",
                        column: x => x.RiverUsageTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RiverPassingProvinces_ProvinceId",
                table: "RiverPassingProvinces",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPassingProvinces_RiverId",
                table: "RiverPassingProvinces",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Rivers_MainBasinId",
                table: "Rivers",
                column: "MainBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverSecondaryBasins_RiverId",
                table: "RiverSecondaryBasins",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverSecondaryBasins_SecondaryBasinId",
                table: "RiverSecondaryBasins",
                column: "SecondaryBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverUsageTypes_RiverId",
                table: "RiverUsageTypes",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverUsageTypes_RiverUsageTypeId",
                table: "RiverUsageTypes",
                column: "RiverUsageTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiverPassingProvinces");

            migrationBuilder.DropTable(
                name: "RiverSecondaryBasins");

            migrationBuilder.DropTable(
                name: "RiverUsageTypes");

            migrationBuilder.DropTable(
                name: "Rivers");
        }
    }
}
