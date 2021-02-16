using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentRequestProtest : IAuditableEntity
   {
      public int Id { get; set; }
      public int SecretariatRegisterDate { get; set; }
      public virtual Upload ProtestLetterFileName { get; set; }

      [StringLength(38)] public string ProtestLetterFileNameId { get; set; }
      public virtual Upload AgendaFileName { get; set; }

      [StringLength(38)] public string AgendaFileNameId { get; set; }
      public int? CommissionDate { get; set; }
      public string Reason { get; set; }
      public bool? CommissionResult { get; set; }
      public int IndustryEstablishmentRequestId { get; set; }
      public virtual IndustryEstablishmentRequest IndustryEstablishmentRequest { get; set; }
   }
}
