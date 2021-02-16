using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentRequest : IAuditableEntity
   {
      public IndustryEstablishmentRequest()
      {
         Establishments = new HashSet<IndustryEstablishment>();
         RequestDate = DateTime.UtcNow;
         Type = IndustryEstablishmentRequestTypes.NewEstablishmentLicense;
      }
      public int Id { get; set; }
      public int SamtProvidedId { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public IndustryEstablishmentRequestTypes Type { get; set; }
      public string PolygonCoordinates { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public virtual User User { get; set; }
      public int UserId { get; set; }
      public virtual Invoice Invoice { get; set; }
      public int? InvoiceId { get; set; }
      public virtual ICollection<IndustryEstablishment> Establishments { get; set; }
      public virtual IndustryEstablishmentRequestProtest Protest { get; set; }
   }

   public enum IndustryEstablishmentRequestTypes : int
   {
      [Display(Name = "صدور مجوز استقرار")] NewEstablishmentLicense = 1,

      [Display(Name = "صدور پروانه بهره برداری")] NewOperationLicense = 2,

      [Display(Name = "تمدید پروانه بهره برداری")] RenewalOperationLicense = 3,

      [Display(Name = "توسعه پروانه بهره برداری")] ExtendOperationLicense = 4,

      [Display(Name = "اکتشاف")] Discovery = 5
   }
}
