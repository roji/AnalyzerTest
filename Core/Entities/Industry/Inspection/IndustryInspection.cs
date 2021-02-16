using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryInspection : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public virtual EnumData InspectReason { get; set; }
      public int? InspectReasonId { get; set; }
      public string InspectDescription { get; set; }
      public virtual Upload InspectDocumentFileName { get; set; }

      [StringLength(38)]
      public string InspectDocumentFileNameId { get; set; }
      public int? InspectingDate { get; set; }
      public string InspectingHour { get; set; }
      public virtual Upload InspectingAgendaFileName { get; set; }

      [StringLength(38)]
      public string InspectingAgendaFileNameId { get; set; }
      public virtual Upload InspectingExpertReportFileName { get; set; }

      [StringLength(38)]
      public string InspectingExpertReportFileNameId { get; set; }
      public virtual Upload MonitoringTypesDocumentFileName { get; set; }

      [StringLength(38)]
      public string MonitoringTypesDocumentFileNameId { get; set; }
      public bool? IsInspectionDone { get; set; }
      public string WhyNotInspectionDoneDescription { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public virtual ICollection<IndustryInspectors> Inspectors { get; set; }
      public virtual ICollection<IndustryInspectingPlaces> Places { get; set; }
      public virtual ICollection<IndustryInspectingMonitoringTypes> InspectingMonitoringTypes { get; set; }
      public IndustryInspection()
      {
         Inspectors = new HashSet<IndustryInspectors>();
         Places = new HashSet<IndustryInspectingPlaces>();
         InspectingMonitoringTypes = new HashSet<IndustryInspectingMonitoringTypes>();
      }
   }
}
