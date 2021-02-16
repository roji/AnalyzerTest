using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveInquiryFileFieldFromEstablishment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                type: "varchar(38)",
                maxLength: 38,
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
