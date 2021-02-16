using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTwoInquiryAnwserFileFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "FirstInquiryAnswerFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "SecondInquiryAnswerFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_Uploads_FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "FirstInquiryAnswerFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_Uploads_SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments",
                column: "SecondInquiryAnswerFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_Uploads_FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_Uploads_SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "FirstInquiryAnswerFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "SecondInquiryAnswerFileNameId",
                table: "IndustryEstablishments");
        }
    }
}
