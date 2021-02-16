using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntInstructionProvinceRegionsLimitation : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual HuntRegion HuntRegion { get; set; }
      public int HuntRegionId { get; set; }
      public virtual HuntInstruction HuntInstruction { get; set; }
      public int HuntInstructionId { get; set; }
   }
}
