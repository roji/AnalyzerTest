using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentInspectionVisitor : IAuditableEntity
   {
      public int Id { get; set; }
      public string FullName { get; set; }
      public string Rank { get; set; }
      public int IndustryEstablishmentId { get; set; }
      public virtual IndustryEstablishment IndustryEstablishment { get; set; }
   }
}
