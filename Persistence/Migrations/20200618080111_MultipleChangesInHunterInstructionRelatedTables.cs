using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MultipleChangesInHunterInstructionRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteOldRecords = @"DELETE FROM HuntInstructions";
            migrationBuilder.Sql(deleteOldRecords);

            migrationBuilder.DropForeignKey(
                name: "FK_HuntInstructionProvinceRegionsLimitations_HuntInstructionPro~",
                table: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.DropTable(
                name: "HuntInstructionProvinceLimitations");

            migrationBuilder.DropIndex(
                name: "IX_HuntInstructionProvinceRegionsLimitations_HuntInstructionPro~",
                table: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.DropColumn(
                name: "HuntInstructionProvinceLimitationId",
                table: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "HuntInstructions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HuntInstructionId",
                table: "HuntInstructionProvinceRegionsLimitations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructions_ProvinceId",
                table: "HuntInstructions",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceRegionsLimitations_HuntInstructionId",
                table: "HuntInstructionProvinceRegionsLimitations",
                column: "HuntInstructionId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntInstructionProvinceRegionsLimitations_HuntInstructions_H~",
                table: "HuntInstructionProvinceRegionsLimitations",
                column: "HuntInstructionId",
                principalTable: "HuntInstructions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HuntInstructions_EnumData_ProvinceId",
                table: "HuntInstructions",
                column: "ProvinceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuntInstructionProvinceRegionsLimitations_HuntInstructions_H~",
                table: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.DropForeignKey(
                name: "FK_HuntInstructions_EnumData_ProvinceId",
                table: "HuntInstructions");

            migrationBuilder.DropIndex(
                name: "IX_HuntInstructions_ProvinceId",
                table: "HuntInstructions");

            migrationBuilder.DropIndex(
                name: "IX_HuntInstructionProvinceRegionsLimitations_HuntInstructionId",
                table: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "HuntInstructionId",
                table: "HuntInstructionProvinceRegionsLimitations");

            migrationBuilder.AddColumn<int>(
                name: "HuntInstructionProvinceLimitationId",
                table: "HuntInstructionProvinceRegionsLimitations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HuntInstructionProvinceLimitations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    HuntInstructionId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceRegionsLimitations_HuntInstructionPro~",
                table: "HuntInstructionProvinceRegionsLimitations",
                column: "HuntInstructionProvinceLimitationId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceLimitations_HuntInstructionId",
                table: "HuntInstructionProvinceLimitations",
                column: "HuntInstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructionProvinceLimitations_ProvinceId",
                table: "HuntInstructionProvinceLimitations",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntInstructionProvinceRegionsLimitations_HuntInstructionPro~",
                table: "HuntInstructionProvinceRegionsLimitations",
                column: "HuntInstructionProvinceLimitationId",
                principalTable: "HuntInstructionProvinceLimitations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
