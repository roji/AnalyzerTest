using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Aquifer : IAuditableEntity
   {
      public Aquifer()
      {
         Provinces = new HashSet<AquiferProvince>();
      }
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<AquiferProvince> Provinces { get; set; }
      public virtual EnumData MainBasin { get; set; }
      public int? MainBasinId { get; set; }
      public virtual EnumData SecondaryBasin { get; set; }
      public int? SecondaryBasinId { get; set; }
      public virtual EnumData StudyArea { get; set; }
      public int? StudyAreaId { get; set; }
      public AquiferTypes Type { get; set; }
      public AquiferStatuses Status { get; set; }
      public double? ElectricalConductivityAverage { get; set; }
      public double? UndergroundWaterLevelAverage { get; set; }
      public double? WaterLevelDepth { get; set; }
      public double? HydraulicSlope { get; set; }
      public string ExistenceOfAquiferSchemes { get; set; }
      public string ExistenceOfWaterResources { get; set; }
      public string OccurrenceOfSubsidenceAndRift { get; set; }
      public virtual ICollection<Plain> Plains { get; set; }
      public virtual ICollection<Altitude> Altitudes { get; set; }
   }

   public enum AquiferTypes : int
   {
      [Display(Name = "آزاد")] Free = 1,

      [Display(Name = "تحت فشار")] UnderPresure = 2
   }

   public enum AquiferStatuses : int
   {
      [Display(Name = "آزاد")] Free = 1,

      [Display(Name = "ممنوعه")] Forbidden = 2,

      [Display(Name = "بحرانی")] Critical = 3
   }
}
