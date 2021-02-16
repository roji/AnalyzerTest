using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HospitalDisinfectionDeviceResult : IAuditableEntity, IAccessControl
   {
      public HospitalDisinfectionDeviceResult()
      {
         GuidanceMonitoringConditions = new HashSet<HospitalGuidanceMonitoringCondition>();
      }
      public int Id { get; set; }
      public string DeviceName { get; set; }
      public DisinfectionDeviceTypes DeviceType { get; set; }
      public virtual ICollection<HospitalGuidanceMonitoringCondition> GuidanceMonitoringConditions { get; set; }
      // PreVacuumAutoClave
      public bool? PreVacuumAutoClaveBiologicalIndex { get; set; }
      public bool? PreVacuumAutoClaveBowieDickChemicalIndex { get; set; }
      public bool? PreVacuumAutoClaveClassFiveSixChemicalIndex { get; set; }
      public bool? PreVacuumAutoClaveGuidanceMonitoringCondition { get; set; }
      // GravityAutoClave
      public bool? GravityAutoClaveGuidanceMonitoringCondition { get; set; }
      public bool? GravityAutoClaveBiologicalIndex { get; set; }
      public bool? GravityAutoClaveClassFiveSixChemicalIndex { get; set; }
      // HydroAutoClave
      public bool? HydroAutoClaveBiologicalIndex { get; set; }
      // DryHeat
      public bool? DryHeatBiologicalIndex { get; set; }
      // Fill IsAcceptable in Service After Add/Update For Future Performance Boost in Queries 
      public bool? IsAcceptable { get; set; }
      public int HospitalSamplingResultId { get; set; }
      public virtual HospitalSamplingResult HospitalSamplingResult { get; set; }
   }
   public enum DisinfectionDeviceTypes : int
   {
      [Display(Name = "اتوکلاو پیش خلاء")] PreVacuumAutoClave = 1,

      [Display(Name = "اتوکلاو گراویتی")] GravityAutoClave = 2,

      [Display(Name = "هیدروکلاو")] HydroAutoClave = 3,

      [Display(Name = "گرمای خشک")] DryHeat = 4
   }
}
