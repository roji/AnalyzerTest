using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class FountainWaterUsage : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual Fountain Fountain { get; set; }
      public int FountainId { get; set; }
      public virtual EnumData WaterUsage { get; set; }
      public int WaterUsageId { get; set; }
   }
}
