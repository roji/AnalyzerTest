using System;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntingLicenseDescription : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual HuntingLicense HuntingLicense { get; set; }
      public int HuntingLicenseId { get; set; }
      public virtual User User { get; set; }
      public int UserId { get; set; }
      public string UserName { get; set; }
      public string UserType { get; set; }
      public string UserComment { get; set; }
      public string SystemComment { get; set; }
      public DateTimeOffset DescriptionDate { get; set; }
      public DescriptionTypes DescriptionType { get; set; }
      public HuntingLicenseStatuses? Status { get; set; }
   }
}
