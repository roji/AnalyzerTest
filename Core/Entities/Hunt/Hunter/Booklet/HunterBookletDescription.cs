using Core.Entities.AuditableEntity;
using System;

namespace Core.Entities
{
   public class HunterBookletDescription : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual HunterBooklet HunterBooklet { get; set; }
      public int HunterBookletId { get; set; }
      public virtual User User { get; set; }
      public int UserId { get; set; }
      public string UserName { get; set; }
      public string UserType { get; set; }
      public string UserComment { get; set; }
      public string SystemComment { get; set; }
      public DateTimeOffset DescriptionDate { get; set; }
      public DescriptionTypes DescriptionType { get; set; }
      public HunterBookletStatuses? Status { get; set; }
   }
}
