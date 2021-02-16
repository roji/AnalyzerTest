using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ResearcherJournalMagazine : IAuditableEntity
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Year { get; set; }
      public string Number { get; set; }
      public string Description { get; set; }
      public int ResearcherId { get; set; }
      public virtual Researcher Researcher { get; set; }
   }
}
