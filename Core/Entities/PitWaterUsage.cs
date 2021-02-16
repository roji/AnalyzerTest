using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class PitWaterUsage : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual Pit Pit { get; set; }
      public int PitId { get; set; }
      public virtual EnumData WaterUsage { get; set; }
      public int WaterUsageId { get; set; }
      public double DailyConsumingVolume { get; set; }
   }
}
