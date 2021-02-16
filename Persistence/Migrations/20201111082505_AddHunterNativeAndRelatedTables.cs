using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHunterNativeAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HunterNatives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HunterId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    ProvinceId = table.Column<int>(nullable: false),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                    table.PrimaryKey("PK_HunterNatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterNatives_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterNatives_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterNatives_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HunterNativeDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HunterNativeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    SystemComment = table.Column<string>(nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(nullable: false),
                    DescriptionType = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HunterNativeDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterNativeDescriptions_HunterNatives_HunterNativeId",
                        column: x => x.HunterNativeId,
                        principalTable: "HunterNatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HunterNativeDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HunterNativeDescriptions_HunterNativeId",
                table: "HunterNativeDescriptions",
                column: "HunterNativeId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterNativeDescriptions_UserId",
                table: "HunterNativeDescriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterNatives_DocumentFileNameId",
                table: "HunterNatives",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterNatives_HunterId",
                table: "HunterNatives",
                column: "HunterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HunterNatives_ProvinceId",
                table: "HunterNatives",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HunterNativeDescriptions");

            migrationBuilder.DropTable(
                name: "HunterNatives");
        }
    }
}
