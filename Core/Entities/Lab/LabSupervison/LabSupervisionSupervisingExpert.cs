using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class LabSupervisionSupervisingExpert : IAuditableEntity
   {
      public int Id { get; set; }
      public string FullName { get; set; }
      public string Rank { get; set; }
      public virtual LabSupervision LabSupervision { get; set; }
      public int LabSupervisionId { get; set; }
   }
}
