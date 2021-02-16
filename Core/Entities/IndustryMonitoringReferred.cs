using System;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryMonitoringReferred : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual IndustryMonitoringReference Reference { get; set; }
      public int ReferenceId { get; set; }
      public virtual Lab Lab { get; set; }
      public int LabId { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public bool IsAccepted { get; set; }
   }
}
