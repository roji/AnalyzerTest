using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class RoleClaim : IAuditableEntity
   {
      public int Id { get; set; }
      public int RoleId { get; set; }
      public virtual Role Role { get; set; }

      [MaxLength(500)]
      public virtual string ClaimType { get; set; }

      [MaxLength(255)]
      public virtual string ClaimValue { get; set; }
   }
}
