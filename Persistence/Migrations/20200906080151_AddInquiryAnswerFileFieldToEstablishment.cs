using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class AddInquiryAnswerFileFieldToEstablishment : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var cmd = "delete from industryestablishments";
         migrationBuilder.Sql(cmd);

         migrationBuilder.AddColumn<string>(
            name: "InquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            maxLength : 38,
            nullable : true);

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_InquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            column: "InquiryAnswerFileNameId");

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishments_Uploads_InquiryAnswerFileNameId",
            table: "IndustryEstablishments",
            column: "InquiryAnswerFileNameId",
            principalTable: "Uploads",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishments_Uploads_InquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_InquiryAnswerFileNameId",
            table: "IndustryEstablishments");

         migrationBuilder.DropColumn(
            name: "InquiryAnswerFileNameId",
            table: "IndustryEstablishments");
      }
   }
}
