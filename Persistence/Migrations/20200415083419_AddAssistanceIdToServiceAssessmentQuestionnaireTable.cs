using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAssistanceIdToServiceAssessmentQuestionnaireTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssistanceId",
                table: "ServiceAssessmentQuestionnaires",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAssessmentQuestionnaires_AssistanceId",
                table: "ServiceAssessmentQuestionnaires",
                column: "AssistanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceAssessmentQuestionnaires_Assistances_AssistanceId",
                table: "ServiceAssessmentQuestionnaires",
                column: "AssistanceId",
                principalTable: "Assistances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceAssessmentQuestionnaires_Assistances_AssistanceId",
                table: "ServiceAssessmentQuestionnaires");

            migrationBuilder.DropIndex(
                name: "IX_ServiceAssessmentQuestionnaires_AssistanceId",
                table: "ServiceAssessmentQuestionnaires");

            migrationBuilder.DropColumn(
                name: "AssistanceId",
                table: "ServiceAssessmentQuestionnaires");
        }
    }
}
