using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryJudicialActionContractor
   {
      public int Id { get; set; }
      public string FullName { get; set; }
      public virtual IndustryJudicialAction JudicialAction { get; set; }
      public int JudicialActionId { get; set; }
   }
}
