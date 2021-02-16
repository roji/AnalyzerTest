using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class BirdsCensusPerson : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual BirdsCensus BirdsCensus { get; set; }
      public int BirdsCensusId { get; set; }
      public string FullName { get; set; }
      public string Rank { get; set; }
   }
}
