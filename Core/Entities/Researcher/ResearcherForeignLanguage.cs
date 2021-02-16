using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ResearcherForeignLanguage : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData ForeignLanguage { get; set; }
      public int ForeignLanguageId { get; set; }
      public virtual Researcher Researcher { get; set; }
      public int ResearcherId { get; set; }
   }
}
