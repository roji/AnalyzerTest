using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class MammalsCensusPerson : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual MammalsCensus MammalsCensus { get; set; }
      public int MammalsCensusId { get; set; }
      public string FullName { get; set; }
      public string Rank { get; set; }
   }
}
