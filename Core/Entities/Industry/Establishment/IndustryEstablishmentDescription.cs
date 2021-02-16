using System;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentDescription : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual IndustryEstablishment IndustryEstablishment { get; set; }
      public int IndustryEstablishmentId { get; set; }
      public virtual User User { get; set; }
      public int UserId { get; set; }
      public string UserName { get; set; }
      public string UserType { get; set; }
      public string UserComment { get; set; }
      public string SystemComment { get; set; }
      public DateTimeOffset DescriptionDate { get; set; }
      public DescriptionTypes DescriptionType { get; set; }
      public IndustryEstablishmentStatuses Status { get; set; }
   }
   public enum DescriptionTypes : int
   {
      Public = 1,
      Secret = 2
   }
}
