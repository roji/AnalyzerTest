using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IndustryEstablishmentTablesChangesApplied : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_Users_StateOfficeExpertId",
                table: "IndustryEstablishments");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionInfoVisitors");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionInfos");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_StateOfficeExpertId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "StateOfficeExpertId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "StateOfficeExpertReferDate",
                table: "IndustryEstablishments");

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "IndustryEstablishments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertId",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ExpertReferDate",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryClassification",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustryCommitmentAndConditions",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InspectionDate",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectionExpertTheory",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectionHour",
                table: "IndustryEstablishments",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovedToDepartment",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionVisitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 350, nullable: false),
                    Rank = table.Column<string>(nullable: true),
                    IndustryEstablishmentId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentInspectionVisitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentInspectionVisitors_IndustryEstablishmen~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentPreviousDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Department = table.Column<int>(nullable: false),
                    IndustryEstablishmentId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentPreviousDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentPreviousDepartments_IndustryEstablishme~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_ExpertId",
                table: "IndustryEstablishments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionVisitors_IndustryEstablishmen~",
                table: "IndustryEstablishmentInspectionVisitors",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentPreviousDepartments_IndustryEstablishme~",
                table: "IndustryEstablishmentPreviousDepartments",
                column: "IndustryEstablishmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_Users_ExpertId",
                table: "IndustryEstablishments",
                column: "ExpertId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_Users_ExpertId",
                table: "IndustryEstablishments");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionVisitors");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentPreviousDepartments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_ExpertId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "ExpertId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "ExpertReferDate",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "IndustryClassification",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "IndustryCommitmentAndConditions",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "InspectionDate",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "InspectionExpertTheory",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "InspectionHour",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "MovedToDepartment",
                table: "IndustryEstablishments");

            migrationBuilder.AddColumn<int>(
                name: "StateOfficeExpertId",
                table: "IndustryEstablishments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "StateOfficeExpertReferDate",
                table: "IndustryEstablishments",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Date = table.Column<int>(type: "int", nullable: false),
                    ExpertTheory = table.Column<string>(type: "longtext", nullable: true),
                    Hour = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    IndustryEstablishmentId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEstablishmentInspectionInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentInspectionInfos_IndustryEstablishments_~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionInfoVisitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    FullName = table.Column<string>(type: "varchar(350)", maxLength: 350, nullable: false),
                    IndustryEstablishmentInspectionInfoId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Rank = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEstablishmentInspectionInfoVisitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentInspectionInfoVisitors_IndustryEstablis~",
                        column: x => x.IndustryEstablishmentInspectionInfoId,
                        principalTable: "IndustryEstablishmentInspectionInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_StateOfficeExpertId",
                table: "IndustryEstablishments",
                column: "StateOfficeExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionInfos_IndustryEstablishmentId",
                table: "IndustryEstablishmentInspectionInfos",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionInfoVisitors_IndustryEstablis~",
                table: "IndustryEstablishmentInspectionInfoVisitors",
                column: "IndustryEstablishmentInspectionInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_Users_StateOfficeExpertId",
                table: "IndustryEstablishments",
                column: "StateOfficeExpertId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
