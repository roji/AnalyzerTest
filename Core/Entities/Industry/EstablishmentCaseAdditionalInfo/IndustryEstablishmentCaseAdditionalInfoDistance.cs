using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentCaseAdditionalInfoDistance : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData DistanceFromCentersAreasEcosystems { get; set; }
      public int DistanceFromCentersAreasEcosystemsId { get; set; }
      public double Distance { get; set; }
      public string Description { get; set; }
      public virtual IndustryEstablishmentCaseAdditionalInfo IndustryEstablishmentCaseAdditionalInfo { get; set; }
      public int IndustryEstablishmentCaseAdditionalInfoId { get; set; }
   }
}
