using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IndustryEstablishmentAddNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InquiryFileNameId",
                table: "IndustryEstablishments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InspectionStageId",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_InquiryFileNameId",
                table: "IndustryEstablishments",
                column: "InquiryFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_InspectionStageId",
                table: "IndustryEstablishments",
                column: "InspectionStageId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_Uploads_InquiryFileNameId",
                table: "IndustryEstablishments",
                column: "InquiryFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_EnumData_InspectionStageId",
                table: "IndustryEstablishments",
                column: "InspectionStageId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_Uploads_InquiryFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_EnumData_InspectionStageId",
                table: "IndustryEstablishments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_InquiryFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_InspectionStageId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "InquiryFileNameId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "InspectionStageId",
                table: "IndustryEstablishments");
        }
    }
}
