using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntRegion : IAuditableEntity
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public virtual EnumData Province { get; set; }
      public int ProvinceId { get; set; }
      public HuntInstructionTypes Type { get; set; }
   }
}
