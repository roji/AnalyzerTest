using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class EstablishmentNewTablesAndChangesApplied : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var deleteOldRecords = @"DELETE FROM IndustryEstablishmentRequests";
         migrationBuilder.Sql(deleteOldRecords);

         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishments_Uploads_FirstInquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishments_Uploads_FirstInquiryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishments_Uploads_SecondInquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishments_Uploads_SecondInquiryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_FirstInquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_FirstInquiryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_SecondInquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_SecondInquiryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "FirstInquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "FirstInquiryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "SecondInquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "SecondInquiryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.AddColumn<string>(
            name: "InspectionExpertTheoryFileNameId",
            table: "IndustryEstablishments",
            maxLength : 38,
            nullable : true);

         migrationBuilder.AddColumn<bool>(
            name: "ShouldUploadDocuments",
            table: "IndustryEstablishments",
            nullable : true);

         migrationBuilder.AddColumn<bool>(
            name: "ShouldUploadInquiries",
            table: "IndustryEstablishments",
            nullable : true);

         migrationBuilder.AddColumn<string>(
            name: "SuggestIndustryCommitments",
            table: "IndustryEstablishments",
            nullable : true);

         migrationBuilder.AddColumn<int>(
            name: "Type",
            table: "IndustryEstablishmentRequests",
            nullable : false,
            defaultValue : 1);

         migrationBuilder.CreateTable(
            name: "IndustryEstablishmentInquiryFiles",
            columns : table => new
            {
               Id = table.Column<int>(nullable: false)
                  .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                  InquiryTypeId = table.Column<int>(nullable: false),
                  InquiryFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                  InquiryAnswerFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
            constraints : table =>
            {
               table.PrimaryKey("PK_IndustryEstablishmentInquiryFiles", x => x.Id);
               table.ForeignKey(
                  name: "FK_IndustryEstablishmentInquiryFiles_IndustryEstablishments_Ind~",
                  column : x => x.IndustryEstablishmentId,
                  principalTable: "IndustryEstablishments",
                  principalColumn: "Id",
                  onDelete : ReferentialAction.Cascade);
               table.ForeignKey(
                  name: "FK_IndustryEstablishmentInquiryFiles_Uploads_InquiryAnswerFileN~",
                  column : x => x.InquiryAnswerFileNameId,
                  principalTable: "Uploads",
                  principalColumn: "Id",
                  onDelete : ReferentialAction.Restrict);
               table.ForeignKey(
                  name: "FK_IndustryEstablishmentInquiryFiles_Uploads_InquiryFileNameId",
                  column : x => x.InquiryFileNameId,
                  principalTable: "Uploads",
                  principalColumn: "Id",
                  onDelete : ReferentialAction.Restrict);
               table.ForeignKey(
                  name: "FK_IndustryEstablishmentInquiryFiles_EnumData_InquiryTypeId",
                  column : x => x.InquiryTypeId,
                  principalTable: "EnumData",
                  principalColumn: "Id",
                  onDelete : ReferentialAction.Restrict);
            });

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_InspectionExpertTheoryFileNameId",
            table: "IndustryEstablishments",
            column: "InspectionExpertTheoryFileNameId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishmentInquiryFiles_IndustryEstablishmentId",
            table: "IndustryEstablishmentInquiryFiles",
            column: "IndustryEstablishmentId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishmentInquiryFiles_InquiryAnswerFileNameId",
            table: "IndustryEstablishmentInquiryFiles",
            column: "InquiryAnswerFileNameId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishmentInquiryFiles_InquiryFileNameId",
            table: "IndustryEstablishmentInquiryFiles",
            column: "InquiryFileNameId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishmentInquiryFiles_InquiryTypeId",
            table: "IndustryEstablishmentInquiryFiles",
            column: "InquiryTypeId");

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishments_Uploads_InspectionExpertTheoryFileNam~",
            table: "IndustryEstablishments",
            column: "InspectionExpertTheoryFileNameId",
            principalTable: "Uploads",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishments_Uploads_InspectionExpertTheoryFileNam~",
            table: "IndustryEstablishments");

         migrationBuilder.DropTable(
            name: "IndustryEstablishmentInquiryFiles");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_InspectionExpertTheoryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "InspectionExpertTheoryFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "ShouldUploadDocuments",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "ShouldUploadInquiries",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "SuggestIndustryCommitments",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "Type",
            table: "IndustryEstablishmentRequests");

         migrationBuilder.AddColumn<string>(
            name: "FirstInquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            type: "varchar(38)",
            maxLength : 38,
            nullable : true);

         migrationBuilder.AddColumn<string>(
            name: "FirstInquiryFileNameId",
            table: "IndustryEstablishments",
            type: "varchar(38)",
            maxLength : 38,
            nullable : true);

         migrationBuilder.AddColumn<string>(
            name: "SecondInquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            type: "varchar(38)",
            maxLength : 38,
            nullable : true);

         migrationBuilder.AddColumn<string>(
            name: "SecondInquiryFileNameId",
            table: "IndustryEstablishments",
            type: "varchar(38)",
            maxLength : 38,
            nullable : true);

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_FirstInquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            column: "FirstInquiryAnswerFileNameId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_FirstInquiryFileNameId",
            table: "IndustryEstablishments",
            column: "FirstInquiryFileNameId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_SecondInquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            column: "SecondInquiryAnswerFileNameId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_SecondInquiryFileNameId",
            table: "IndustryEstablishments",
            column: "SecondInquiryFileNameId");

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishments_Uploads_FirstInquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            column: "FirstInquiryAnswerFileNameId",
            principalTable: "Uploads",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishments_Uploads_FirstInquiryFileNameId",
            table: "IndustryEstablishments",
            column: "FirstInquiryFileNameId",
            principalTable: "Uploads",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishments_Uploads_SecondInquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            column: "SecondInquiryAnswerFileNameId",
            principalTable: "Uploads",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishments_Uploads_SecondInquiryFileNameId",
            table: "IndustryEstablishments",
            column: "SecondInquiryFileNameId",
            principalTable: "Uploads",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);
      }
   }
}
