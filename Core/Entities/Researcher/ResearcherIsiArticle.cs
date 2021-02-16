using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ResearcherIsiArticle : IAuditableEntity
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Year { get; set; }
      public string Language { get; set; }
      public string Acceptor { get; set; }
      public string Description { get; set; }
      public int ResearcherId { get; set; }
      public virtual Researcher Researcher { get; set; }
   }
}
