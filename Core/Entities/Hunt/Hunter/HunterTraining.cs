using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HunterTraining : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual Hunter Hunter { get; set; }
      public int HunterId { get; set; }
      public int LicenseDate { get; set; }
      public string LicenseNumber { get; set; }
      public string Description { get; set; }
   }
}
