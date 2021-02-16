using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class AqueductWell : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual Aqueduct Aqueduct { get; set; }
      public int AqueductId { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
   }
}
