using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class ServiceAssessmentQuestionnaire : IAuditableEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset QuestionnaireDateTime { get; set; }
        public bool? Gender { get; set; } // Female = False , Male = true
        public int? Age { get; set; }
        public string Job { get; set; }
        public int? GradeId { get; set; }
        public virtual EnumData Grade { get; set; }
        public int? AssistanceId { get; set; }
        public virtual Assistance Assistance { get; set; }
        public int? LatelyReceivingServiceCount { get; set; }
        public QuestionnaireChoices? JobStepsNotification { get; set; }
        public QuestionnaireChoices? RequiredDocumentsNotification { get; set; }
        public QuestionnaireChoices? AdministrativeRulesNoPersonalJudgements { get; set; }
        public QuestionnaireChoices? GuidanceByEmployees { get; set; }
        public QuestionnaireChoices? QualityOfWork { get; set; }
        public QuestionnaireChoices? CostOfDoingTheWork { get; set; }
        public QuestionnaireChoices? PersonInChargeBehaveAndGuide { get; set; }
        public QuestionnaireChoices? AmenitiesAndServiceSpace { get; set; }
        public QuestionnaireChoices? BeingOnPointAndClearInHandling { get; set; }
        public QuestionnaireChoices? EmployeeAccuracyWithoutRework { get; set; }
        public QuestionnaireChoices? SpeedOfWork { get; set; }
        public QuestionnaireChoices? VisitOrganizationToReceiveServiceCount { get; set; }
        public QuestionnaireChoices? ServiceDeliveryCommitment { get; set; }
        public QuestionnaireChoices? ReferralDifferentDepartmentsToReceiveService { get; set; }
        public QuestionnaireChoices? OrderEaseOfAccessToFacilitiesForService { get; set; }
        public QuestionnaireChoices? ReceivingDocumentsOnlineOrOfflineAtOnes { get; set; }
        public QuestionnaireChoices? PresentingDuplicateInformation { get; set; }
        public QuestionnaireChoices? FeelNeedOfRecommendationToReceiveService { get; set; }
        public QuestionnaireChoices? FeelingSatisfiedWithTheWholeService { get; set; }
        public string HowDoYouPreferToContactPersonInCharge { get; set; }
        public string AdditionalDescription { get; set; }
    }
    public enum QuestionnaireChoices : int
    {
        [Display(Name = "خیلی کم")] VeryLow = 1,
        [Display(Name = "کم")] Low = 2,
        [Display(Name = "متوسط")] Normal = 3,
        [Display(Name = "زیاد")] High = 4,
        [Display(Name = "خیلی زیاد")] VeryHigh = 5
    }
}
