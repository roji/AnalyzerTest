using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentDocumentFilesTableAndUpdateEstablishmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProfileCompleted",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileCompletedDescription",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "StateOfficeExpertReferDate",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentDocumentFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DocumentTypeId = table.Column<int>(nullable: false),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    ApproveDocument = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryEstablishmentDocumentFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDocumentFiles_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDocumentFiles_EnumData_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDocumentFiles_IndustryEstablishments_In~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDocumentFiles_DocumentFileNameId",
                table: "IndustryEstablishmentDocumentFiles",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDocumentFiles_DocumentTypeId",
                table: "IndustryEstablishmentDocumentFiles",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDocumentFiles_IndustryEstablishmentId",
                table: "IndustryEstablishmentDocumentFiles",
                column: "IndustryEstablishmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEstablishmentDocumentFiles");

            migrationBuilder.DropColumn(
                name: "IsProfileCompleted",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "ProfileCompletedDescription",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "StateOfficeExpertReferDate",
                table: "IndustryEstablishments");
        }
    }
}
