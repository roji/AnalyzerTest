using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveServiceIdFromAssessmentQuestionnaireTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceAssessmentQuestionnaires_EnumData_ServiceId",
                table: "ServiceAssessmentQuestionnaires");

            migrationBuilder.DropIndex(
                name: "IX_ServiceAssessmentQuestionnaires_ServiceId",
                table: "ServiceAssessmentQuestionnaires");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "ServiceAssessmentQuestionnaires");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "ServiceAssessmentQuestionnaires",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAssessmentQuestionnaires_ServiceId",
                table: "ServiceAssessmentQuestionnaires",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceAssessmentQuestionnaires_EnumData_ServiceId",
                table: "ServiceAssessmentQuestionnaires",
                column: "ServiceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
