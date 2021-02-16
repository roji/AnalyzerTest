using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ResearcherEducation : IAuditableEntity
   {
      public int Id { get; set; }
      public int Year { get; set; }
      public virtual EnumData Major { get; set; }
      public int? MajorId { get; set; }
      public virtual EnumData Grade { get; set; }
      public int? GradeId { get; set; }
      public string University { get; set; }
      public string Description { get; set; }
      public int ResearcherId { get; set; }
      public virtual Researcher Researcher { get; set; }
   }
}
