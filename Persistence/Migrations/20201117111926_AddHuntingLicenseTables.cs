using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHuntingLicenseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HuntingLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    HuntInstructionId = table.Column<int>(nullable: false),
                    HunterId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HuntingLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntingLicenses_HuntInstructions_HuntInstructionId",
                        column: x => x.HuntInstructionId,
                        principalTable: "HuntInstructions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HuntingLicenses_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HuntingLicenseDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HuntingLicenseId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    SystemComment = table.Column<string>(nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(nullable: false),
                    DescriptionType = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HuntingLicenseDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntingLicenseDescriptions_HuntingLicenses_HuntingLicenseId",
                        column: x => x.HuntingLicenseId,
                        principalTable: "HuntingLicenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntingLicenseDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLicenseDescriptions_HuntingLicenseId",
                table: "HuntingLicenseDescriptions",
                column: "HuntingLicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLicenseDescriptions_UserId",
                table: "HuntingLicenseDescriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLicenses_HuntInstructionId",
                table: "HuntingLicenses",
                column: "HuntInstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLicenses_HunterId",
                table: "HuntingLicenses",
                column: "HunterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HuntingLicenseDescriptions");

            migrationBuilder.DropTable(
                name: "HuntingLicenses");
        }
    }
}
