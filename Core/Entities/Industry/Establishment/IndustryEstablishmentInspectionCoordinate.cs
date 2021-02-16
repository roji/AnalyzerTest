using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentInspectionCoordinate : IAuditableEntity
   {
      public int Id { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public int IndustryEstablishmentId { get; set; }
      public virtual IndustryEstablishment IndustryEstablishment { get; set; }
   }
}
