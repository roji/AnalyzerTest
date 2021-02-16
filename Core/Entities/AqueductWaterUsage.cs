using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class AqueductWaterUsage : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual Aqueduct Aqueduct { get; set; }
      public int AqueductId { get; set; }
      public virtual EnumData WaterUsage { get; set; }
      public int WaterUsageId { get; set; }
   }
}
