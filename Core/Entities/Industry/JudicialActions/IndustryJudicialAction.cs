using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryJudicialAction : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public int Date { get; set; }
      public string Subject { get; set; }
      public string Reason { get; set; }
      public string Description { get; set; }

      public virtual EnumData CaseStatus { get; set; }
      public int? CaseStatusId { get; set; }
      public virtual EnumData Verdict { get; set; }
      public int? VerdictId { get; set; }

      public virtual Upload ViolationAgendaFileName { get; set; }

      [StringLength(38)]
      public string ViolationAgendaFileNameId { get; set; }
      public virtual Upload JudicialActionSheetFileName { get; set; }

      [StringLength(38)]
      public string JudicialActionSheetFileNameId { get; set; }
      public virtual Upload VerdictFileName { get; set; }

      [StringLength(38)]
      public string VerdictFileNameId { get; set; }
      public string RelevantLegalMaterial { get; set; }
      public string JudicalCaseNumber { get; set; }
      public string CourtName { get; set; }
      public string ConsequencesAndGeneralitiesOfVerdict { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public virtual ICollection<IndustryJudicialActionContractor> Contractors { get; set; }
      public IndustryJudicialAction()
      {
         Contractors = new HashSet<IndustryJudicialActionContractor>();
         FinalSave = false;
      }
   }
}
