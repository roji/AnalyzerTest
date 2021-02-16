using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentFinancialRelation : IAuditableEntity
   {
      public IndustryEstablishmentFinancialRelation()
      {
         Services = new HashSet<IndustryEstablishmentFinancialRelationServices>();
      }
      public int Id { get; set; }
      public Industry.IndustryClassifications Classification { get; set; }
      public bool IsKnowledgeBased { get; set; }
      public virtual EnumData ApplicantStatus { get; set; }
      public int ApplicantStatusId { get; set; }
      public virtual ICollection<IndustryEstablishmentFinancialRelationServices> Services { get; set; }
   }
   public class IndustryEstablishmentFinancialRelationServices : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual IndustryEstablishmentFinancialRelation IndustryEstablishmentFinancialRelation { get; set; }
      public int IndustryEstablishmentFinancialRelationId { get; set; }
      public virtual Service Service { get; set; }
      public int ServiceId { get; set; }
      public int DiscountPercentage { get; set; }
   }
}
