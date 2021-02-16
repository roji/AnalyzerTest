using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Pit : IAuditableEntity
   {
      public Pit()
      {
         WaterUsages = new HashSet<PitWaterUsage>();
      }
      public int Id { get; set; }
      public string Name { get; set; }
      public bool HasLicense { get; set; }
      public string LicenseNumber { get; set; }
      public virtual Plain Plain { get; set; }
      public int? PlainId { get; set; }
      public virtual Altitude Altitude { get; set; }
      public int? AltitudeId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData State { get; set; }
      public int? StateId { get; set; }
      public virtual EnumData City { get; set; }
      public int? CityId { get; set; }
      public string Village { get; set; }
      public virtual EnumData PitType { get; set; }
      public int? PitTypeId { get; set; }
      public virtual EnumData PitWaterSourceStabilityType { get; set; }
      public int? PitWaterSourceStabilityTypeId { get; set; }
      public double? ExitVolumeDailyAverage { get; set; }
      public double? ConsumingVolumeMonthlyAverage { get; set; }
      public string Consumers { get; set; }
      public string VisualSpecification { get; set; }
      public bool? HasConsumptionMeter { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public double? PitElevation { get; set; }
      public double? PitDiameter { get; set; }
      public double? StorageVolume { get; set; }
      public string Description { get; set; }
      public virtual ICollection<PitWaterUsage> WaterUsages { get; set; }
   }
}
