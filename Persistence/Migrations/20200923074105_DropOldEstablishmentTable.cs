using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DropOldEstablishmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishmentInspectionDates_IndustryEstablishments_~",
                table: "IndustryEstablishmentInspectionDates");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentDescriptions");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentDocumentFiles");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionVisitors");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentPreviousDepartments");

            migrationBuilder.DropTable(
                name: "IndustryEstablishments");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionDates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Department = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    ExpertReferDate = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    FirstInquiryAnswerFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    IndustryClassification = table.Column<int>(type: "int", nullable: true),
                    IndustryCommitmentAndConditions = table.Column<string>(type: "longtext", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    InquiryFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    InspectionDate = table.Column<int>(type: "int", nullable: true),
                    InspectionExpertTheory = table.Column<string>(type: "longtext", nullable: true),
                    InspectionHour = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    InspectionStageId = table.Column<int>(type: "int", nullable: true),
                    IsProfileCompleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    MovedToDepartment = table.Column<int>(type: "int", nullable: true),
                    PolygonCoordinates = table.Column<string>(type: "longtext", nullable: true),
                    ProfileCompletedDescription = table.Column<string>(type: "longtext", nullable: true),
                    RepId = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    SecondInquiryAnswerFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    SelectedInspectionDateId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEstablishments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Users_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Uploads_FirstInquiryAnswerFileNameId",
                        column: x => x.FirstInquiryAnswerFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Uploads_InquiryFileNameId",
                        column: x => x.InquiryFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_EnumData_InspectionStageId",
                        column: x => x.InspectionStageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Uploads_SecondInquiryAnswerFileNameId",
                        column: x => x.SecondInquiryAnswerFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    DescriptionType = table.Column<int>(type: "int", nullable: false),
                    IndustryEstablishmentId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    SystemComment = table.Column<string>(type: "longtext", nullable: true),
                    UserComment = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    UserType = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEstablishmentDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDescriptions_IndustryEstablishments_Ind~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentDocumentFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApproveDocument = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    DocumentFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    IndustryEstablishmentId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Date = table.Column<int>(type: "int", nullable: false),
                    Hour = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    IndustryEstablishmentId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEstablishmentInspectionDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentInspectionDates_IndustryEstablishments_~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionVisitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    FullName = table.Column<string>(type: "varchar(350)", maxLength: 350, nullable: false),
                    IndustryEstablishmentId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Rank = table.Column<string>(type: "longtext", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Department = table.Column<int>(type: "int", nullable: false),
                    IndustryEstablishmentId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    PreviousIndustryEstablishmentId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentPreviousDepartments_IndustryEstablishm~1",
                        column: x => x.PreviousIndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDescriptions_IndustryEstablishmentId",
                table: "IndustryEstablishmentDescriptions",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDescriptions_UserId",
                table: "IndustryEstablishmentDescriptions",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionDates_IndustryEstablishmentId",
                table: "IndustryEstablishmentInspectionDates",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentInspectionVisitors_IndustryEstablishmen~",
                table: "IndustryEstablishmentInspectionVisitors",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentPreviousDepartments_IndustryEstablishme~",
                table: "IndustryEstablishmentPreviousDepartments",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentPreviousDepartments_PreviousIndustryEst~",
                table: "IndustryEstablishmentPreviousDepartments",
                column: "PreviousIndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_ExpertId",
                table: "IndustryEstablishments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "FirstInquiryAnswerFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_IndustryId",
                table: "IndustryEstablishments",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_InquiryFileNameId",
                table: "IndustryEstablishments",
                column: "InquiryFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_InspectionStageId",
                table: "IndustryEstablishments",
                column: "InspectionStageId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_RepId",
                table: "IndustryEstablishments",
                column: "RepId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "SecondInquiryAnswerFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_SelectedInspectionDateId",
                table: "IndustryEstablishments",
                column: "SelectedInspectionDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_IndustryEstablishmentInspectionDates_~",
                table: "IndustryEstablishments",
                column: "SelectedInspectionDateId",
                principalTable: "IndustryEstablishmentInspectionDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
