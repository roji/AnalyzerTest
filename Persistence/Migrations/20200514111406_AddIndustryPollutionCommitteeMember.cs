using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryPollutionCommitteeMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "IndustryPollutionTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "IndustryPollutionReasons");

            migrationBuilder.CreateTable(
                name: "IndustryPollutionCommitteeMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryPollutionId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 300, nullable: false),
                    Rank = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryPollutionCommitteeMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryPollutionCommitteeMembers_IndustryPollutions_Industr~",
                        column: x => x.IndustryPollutionId,
                        principalTable: "IndustryPollutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutionCommitteeMembers_IndustryPollutionId",
                table: "IndustryPollutionCommitteeMembers",
                column: "IndustryPollutionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryPollutionCommitteeMembers");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "IndustryPollutionTypes",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "IndustryPollutionTypes",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "IndustryPollutionTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "IndustryPollutionTypes",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "IndustryPollutionTypes",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "IndustryPollutionTypes",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "IndustryPollutionTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "IndustryPollutionTypes",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "IndustryPollutionReasons",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "IndustryPollutionReasons",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "IndustryPollutionReasons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "IndustryPollutionReasons",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "IndustryPollutionReasons",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "IndustryPollutionReasons",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "IndustryPollutionReasons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "IndustryPollutionReasons",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
