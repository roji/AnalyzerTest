using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHuntInstructionRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HuntInstructions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnnouncedDate = table.Column<int>(nullable: false),
                    InstructionNumber = table.Column<double>(nullable: true),
                    HuntingTypeId = table.Column<int>(nullable: false),
                    AnimalTypeId = table.Column<int>(nullable: false),
                    FromDate = table.Column<int>(nullable: true),
                    ToDate = table.Column<int>(nullable: true),
                    FromHour = table.Column<string>(maxLength: 10, nullable: true),
                    ToHour = table.Column<string>(maxLength: 10, nullable: true),
                    HuntQuantity = table.Column<int>(nullable: true),
                    NativeLicenseAllowedMaximum = table.Column<int>(nullable: true),
                    NonNativeLicenseAllowedMaximum = table.Column<int>(nullable: true),
                    ForeignLicenseAllowedMaximum = table.Column<int>(nullable: true),
                    NativeLicenseFee = table.Column<double>(nullable: true),
                    NonNativeLicenseFee = table.Column<double>(nullable: true),
                    ForeignLicenseFee = table.Column<double>(nullable: true),
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
                    table.PrimaryKey("PK_HuntInstructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntInstructions_EnumData_AnimalTypeId",
                        column: x => x.AnimalTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HuntInstructions_EnumData_HuntingTypeId",
                        column: x => x.HuntingTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HuntInstructionProvinceLimitations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProvinceId = table.Column<int>(nullable: false),
                    HuntInstructionId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HuntInstructionProvinceLimitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntInstructionProvinceLimitations_HuntInstructions_HuntInst~",
                        column: x => x.HuntInstructionId,
                        principalTable: "HuntInstructions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntInstructionProvinceLimitations_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HuntInstructionWeekLimitations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DayInWeekId = table.Column<int>(nullable: false),
                    HuntInstructionId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HuntInstructionWeekLimitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntInstructionWeekLimitations_EnumData_DayInWeekId",
                        column: x => x.DayInWeekId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HuntInstructionWeekLimitations_HuntInstructions_HuntInstruct~",
                        column: x => x.HuntInstructionId,
                        principalTable: "HuntInstructions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HuntInstructionProvinceRegionsLimitations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProvinceRegionId = table.Column<int>(nullable: false),
                    HuntInstructionProvinceLimitationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HuntInstructionProvinceRegionsLimitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntInstructionProvinceRegionsLimitations_HuntInstructionPro~",
                        column: x => x.HuntInstructionProvinceLimitationId,
                        principalTable: "HuntInstructionProvinceLimitations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntInstructionProvinceRegionsLimitations_EnumData_ProvinceR~",
                        column: x => x.ProvinceRegionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceLimitations_HuntInstructionId",
                table: "HuntInstructionProvinceLimitations",
                column: "HuntInstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceLimitations_ProvinceId",
                table: "HuntInstructionProvinceLimitations",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceRegionsLimitations_HuntInstructionPro~",
                table: "HuntInstructionProvinceRegionsLimitations",
                column: "HuntInstructionProvinceLimitationId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceRegionsLimitations_ProvinceRegionId",
                table: "HuntInstructionProvinceRegionsLimitations",
                column: "ProvinceRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructions_AnimalTypeId",
                table: "HuntInstructions",
                column: "AnimalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructions_HuntingTypeId",
                table: "HuntInstructions",
                column: "HuntingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionWeekLimitations_DayInWeekId",
                table: "HuntInstructionWeekLimitations",
                column: "DayInWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionWeekLimitations_HuntInstructionId",
                table: "HuntInstructionWeekLimitations",
                column: "HuntInstructionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.DropTable(
                name: "HuntInstructionWeekLimitations");

            migrationBuilder.DropTable(
                name: "HuntInstructionProvinceLimitations");

            migrationBuilder.DropTable(
                name: "HuntInstructions");
        }
    }
}
