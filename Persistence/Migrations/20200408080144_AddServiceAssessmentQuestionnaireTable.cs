using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddServiceAssessmentQuestionnaireTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceAssessmentQuestionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    QuestionnaireDateTime = table.Column<DateTimeOffset>(nullable: false),
                    Gender = table.Column<bool>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    GradeId = table.Column<int>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    LatelyReceivingServiceCount = table.Column<int>(nullable: true),
                    JobStepsNotification = table.Column<int>(nullable: true),
                    RequiredDocumentsNotification = table.Column<int>(nullable: true),
                    AdministrativeRulesNoPersonalJudgements = table.Column<int>(nullable: true),
                    GuidanceByEmployees = table.Column<int>(nullable: true),
                    QualityOfWork = table.Column<int>(nullable: true),
                    CostOfDoingTheWork = table.Column<int>(nullable: true),
                    PersonInChargeBehaveAndGuide = table.Column<int>(nullable: true),
                    AmenitiesAndServiceSpace = table.Column<int>(nullable: true),
                    BeingOnPointAndClearInHandling = table.Column<int>(nullable: true),
                    EmployeeAccuracyWithoutRework = table.Column<int>(nullable: true),
                    SpeedOfWork = table.Column<int>(nullable: true),
                    VisitOrganizationToReceiveServiceCount = table.Column<int>(nullable: true),
                    ServiceDeliveryCommitment = table.Column<int>(nullable: true),
                    ReferralDifferentDepartmentsToReceiveService = table.Column<int>(nullable: true),
                    OrderEaseOfAccessToFacilitiesForService = table.Column<int>(nullable: true),
                    ReceivingDocumentsOnlineOrOfflineAtOnes = table.Column<int>(nullable: true),
                    PresentingDuplicateInformation = table.Column<int>(nullable: true),
                    FeelNeedOfRecommendationToReceiveService = table.Column<int>(nullable: true),
                    FeelingSatisfiedWithTheWholeService = table.Column<int>(nullable: true),
                    HowDoYouPreferToContactPersonInCharge = table.Column<string>(nullable: true),
                    AdditionalDescription = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_ServiceAssessmentQuestionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceAssessmentQuestionnaires_EnumData_GradeId",
                        column: x => x.GradeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceAssessmentQuestionnaires_EnumData_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAssessmentQuestionnaires_GradeId",
                table: "ServiceAssessmentQuestionnaires",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAssessmentQuestionnaires_ServiceId",
                table: "ServiceAssessmentQuestionnaires",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceAssessmentQuestionnaires");
        }
    }
}
