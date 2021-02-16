using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IndustryWarningFieldsChangesNewTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IndustryWarnings_FinalSave",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "IndustryWarnings");

            migrationBuilder.AddColumn<int>(
                name: "IndustrialUnitsSamplingResultId",
                table: "IndustryWarnings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "IndustryWarnings",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateTable(
                name: "IndustryWarningDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryWarningId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryWarningDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryWarningDescriptions_IndustryWarnings_IndustryWarning~",
                        column: x => x.IndustryWarningId,
                        principalTable: "IndustryWarnings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryWarningDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_IndustrialUnitsSamplingResultId",
                table: "IndustryWarnings",
                column: "IndustrialUnitsSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarningDescriptions_IndustryWarningId",
                table: "IndustryWarningDescriptions",
                column: "IndustryWarningId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarningDescriptions_UserId",
                table: "IndustryWarningDescriptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryWarnings_IndustrialUnitsSamplingResults_IndustrialUn~",
                table: "IndustryWarnings",
                column: "IndustrialUnitsSamplingResultId",
                principalTable: "IndustrialUnitsSamplingResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryWarnings_IndustrialUnitsSamplingResults_IndustrialUn~",
                table: "IndustryWarnings");

            migrationBuilder.DropTable(
                name: "IndustryWarningDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_IndustryWarnings_IndustrialUnitsSamplingResultId",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "IndustrialUnitsSamplingResultId",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "IndustryWarnings");

            migrationBuilder.AddColumn<int>(
                name: "CommentDate",
                table: "IndustryWarnings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "IndustryWarnings",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "IndustryWarnings",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_FinalSave",
                table: "IndustryWarnings",
                column: "FinalSave");
        }
    }
}
