using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SamtProvidedId = table.Column<int>(nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    PolygonCoordinates = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustryEstablishmentRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentRequests_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Department = table.Column<int>(nullable: false),
                    ExpertId = table.Column<int>(nullable: true),
                    IsProfileCompleted = table.Column<bool>(nullable: true),
                    ProfileCompletedDescription = table.Column<string>(nullable: true),
                    SelectedInspectionDateId = table.Column<int>(nullable: true),
                    InspectionDate = table.Column<int>(nullable: true),
                    InspectionHour = table.Column<string>(maxLength: 10, nullable: true),
                    InspectionExpertTheory = table.Column<string>(nullable: true),
                    IndustryClassification = table.Column<int>(nullable: true),
                    IndustryCommitmentAndConditions = table.Column<string>(nullable: true),
                    InspectionStageId = table.Column<int>(nullable: true),
                    FirstInquiryFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    SecondInquiryFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    FirstInquiryAnswerFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    SecondInquiryAnswerFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                        name: "FK_IndustryEstablishments_Uploads_FirstInquiryFileNameId",
                        column: x => x.FirstInquiryFileNameId,
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
                        name: "FK_IndustryEstablishments_IndustryEstablishmentRequests_Request~",
                        column: x => x.RequestId,
                        principalTable: "IndustryEstablishmentRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Uploads_SecondInquiryAnswerFileNameId",
                        column: x => x.SecondInquiryAnswerFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Uploads_SecondInquiryFileNameId",
                        column: x => x.SecondInquiryFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEstablishmentId = table.Column<int>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentInspectionDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(maxLength: 10, nullable: true),
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
                name: "IX_IndustryEstablishmentRequests_IndustryId",
                table: "IndustryEstablishmentRequests",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentRequests_SamtProvidedId",
                table: "IndustryEstablishmentRequests",
                column: "SamtProvidedId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_ExpertId",
                table: "IndustryEstablishments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "FirstInquiryAnswerFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_FirstInquiryFileNameId",
                table: "IndustryEstablishments",
                column: "FirstInquiryFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_InspectionStageId",
                table: "IndustryEstablishments",
                column: "InspectionStageId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_RequestId",
                table: "IndustryEstablishments",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "SecondInquiryAnswerFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_SecondInquiryFileNameId",
                table: "IndustryEstablishments",
                column: "SecondInquiryFileNameId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IndustryEstablishments");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentRequests");

            migrationBuilder.DropTable(
                name: "IndustryEstablishmentInspectionDates");
        }
    }
}
