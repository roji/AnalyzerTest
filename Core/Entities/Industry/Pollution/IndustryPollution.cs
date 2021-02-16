using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryPollution : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public int? AnnouncementDate { get; set; }
      public int? Year { get; set; }
      public virtual EnumData Season { get; set; }
      public int? SeasonId { get; set; }
      public virtual Upload PollutionDetectionCommitteeFileName { get; set; }

      [StringLength(38)]
      public string PollutionDetectionCommitteeFileNameId { get; set; }
      public string Description { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)]
      public string DocumentFileNameId { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public virtual CommitteeResults? CommitteeResultVote { get; set; }
      public string CommitteeResultDescription { get; set; }
      public virtual CommitteeResults? GeneralManagerVote { get; set; }
      public string GeneralManagerDescription { get; set; }
      public virtual CommitteeResults? TechnicalAssistantVote { get; set; }
      public string TechnicalAssistantDescription { get; set; }
      public virtual CommitteeResults? HeadOfHumanEnvironmentVote { get; set; }
      public string HeadOfHumanEnvironmentDescription { get; set; }
      public virtual CommitteeResults? HeadOfMonitoringDepartmentVote { get; set; }
      public string HeadOfMonitoringDepartmentDescription { get; set; }
      public virtual CommitteeResults? HeadOfLaboratoryAdministrationVote { get; set; }
      public string HeadOfLaboratoryAdministrationDescription { get; set; }
      public virtual CommitteeResults? HeadOfCountyOfficeVote { get; set; }
      public string HeadOfCountyOfficeDescription { get; set; }
      public virtual CommitteeResults? LegalAssistantVote { get; set; }
      public string LegalAssistantDescription { get; set; }
      public virtual ICollection<IndustryPollutionReasons> PollutionReasons { get; set; }
      public virtual ICollection<IndustryPollutionTypes> PollutionTypes { get; set; }
      public virtual ICollection<IndustryPollutionCommitteeMember> CommitteeMembers { get; set; }
      public IndustryPollution()
      {
         PollutionReasons = new HashSet<IndustryPollutionReasons>();
         PollutionTypes = new HashSet<IndustryPollutionTypes>();
         CommitteeMembers = new HashSet<IndustryPollutionCommitteeMember>();
      }
      public enum CommitteeResults : int
      {
         [Display(Name = "در فهرست قرار داده شود")] PlacedOnList = 1, [Display(Name = "مهلت داده شود")] TimeExpanded = 2
      }
   }
}
