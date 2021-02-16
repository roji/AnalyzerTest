using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class AquiferProvince : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData Province { get; set; }
      public int ProvinceId { get; set; }
      public virtual Aquifer Aquifer { get; set; }
      public int AquiferId { get; set; }
   }
}
