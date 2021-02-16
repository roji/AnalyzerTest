using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ResearcherSkill : IAuditableEntity
   {
      public int Id { get; set; }
      public string SpecialtyDescription { get; set; }
      public string ExperienceDescription { get; set; }
      public string Description { get; set; }
      public int ResearcherId { get; set; }
      public virtual Researcher Researcher { get; set; }
   }
}
