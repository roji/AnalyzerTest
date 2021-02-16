using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryMonitoringReference : IAuditableEntity
   {
      public IndustryMonitoringReference()
      {
         Referreds = new HashSet<IndustryMonitoringReferred>();
         Date = DateTime.UtcNow;
      }
      public int Id { get; set; }
      public DateTimeOffset Date { get; set; }
      public int MaximumReferenceForLabs { get; set; }
      public virtual EnumData Season { get; set; }
      public int SeasonId { get; set; }
      public int Year { get; set; }
      // Priority Rates First To Fourth 1-4 Questions
      public int FirstPriorityRateDistance { get; set; }
      public int FirstPriorityRateParamInclusionPercentage { get; set; }
      public int SecondPriorityRateDistance { get; set; }
      public int SecondPriorityRateParamInclusionPercentage { get; set; }
      public int ThirdPriorityRateDistance { get; set; }
      public int ThirdPriorityRateParamInclusionPercentage { get; set; }
      public int FourthPriorityRateDistance { get; set; }
      public int FourthPriorityRateParamInclusionPercentage { get; set; }
      public Industry.IndustryClassifications IndustriesStatus { get; set; }
      public bool ShouldLabsPublicInfoChecked { get; set; }
      public bool ShouldLabsPersonnelChecked { get; set; }
      public bool ShouldLabsEquipmentChecked { get; set; }
      public bool ShouldLabsParameterAndMeasurementMethodChecked { get; set; }
      public bool ShouldLabsConsumingMaterialChecked { get; set; }
      public bool IndustryDoesntMonitoredBySameLabInPreviousSeason { get; set; }
      public bool ShouldCheckLabsMaximumRialVolume { get; set; }
      public Int64? MaximumRialVolume { get; set; }
      public virtual ICollection<IndustryMonitoringReferred> Referreds { get; set; }
   }
}
