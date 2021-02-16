using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ProductClassification : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData IsicCode10 { get; set; }
      public int IsicCode10Id { get; set; }
      public Industry.IndustryClassifications Classification { get; set; }
      public Industry.IndustryClassifications KnowledgebasedClassification { get; set; }
   }
}
