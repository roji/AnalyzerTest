using System;
using System.ComponentModel.DataAnnotations;
namespace Core.Entities
{
   public enum TrackingTypes : int
   {
      [Display(Name = "ثبت نام")] Register = 1,

      [Display(Name = "شکایت")] Complaint = 2,

      [Display(Name = "درخواست استقرار")] EstablishmentRequest = 3,

      [Display(Name = "درخواست صدور دفترچه شکار")] HunterBooklet = 4,

      [Display(Name = "درخواست صدور پروانه شکار")] HuntingLicense = 5,

      [Display(Name = "درخواست مجوز ورود به منطقه شکار")] HuntRegionEntranceCertificate = 6
   }
}
