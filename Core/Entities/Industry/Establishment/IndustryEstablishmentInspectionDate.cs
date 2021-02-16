using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentInspectionDate : IAuditableEntity
   {
      public int Id { get; set; }
      public int Date { get; set; }
      public string Hour { get; set; }
      public int IndustryEstablishmentId { get; set; }
      public virtual IndustryEstablishment IndustryEstablishment { get; set; }
   }
}
