using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentDocumentFile : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData DocumentType { get; set; }
      public int DocumentTypeId { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)] public string DocumentFileNameId { get; set; }
      public bool? ApproveDocument { get; set; }
      public string Description { get; set; }
      public int IndustryEstablishmentId { get; set; }
      public virtual IndustryEstablishment IndustryEstablishment { get; set; }
   }
}
