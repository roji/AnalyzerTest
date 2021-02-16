using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HospitalGuidanceMonitoringCondition : IAuditableEntity
   {
      public int Id { get; set; }
      public int DisinfectionDeviceResultId { get; set; }
      public virtual HospitalDisinfectionDeviceResult DisinfectionDeviceResult { get; set; }
      public virtual EnumData GuidanceMonitoringCondition { get; set; }
      public int GuidanceMonitoringConditionId { get; set; }
      public AutoClaveTypes AutoClaveType { get; set; }
   }
   public enum AutoClaveTypes : int
   {
      [Display(Name = "اتوکلاو پیش خلاء")] PreVacuum = 1,

      [Display(Name = "اتوکلاو گراویتی")] Gravity = 2
   }
}
