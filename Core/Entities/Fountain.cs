using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Fountain : IAuditableEntity
   {
      public Fountain()
      {
         WaterUsages = new HashSet<FountainWaterUsage>();
      }
      public int Id { get; set; }
      public string Name { get; set; }
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
      public virtual EnumData FountainType { get; set; }
      public int? FountainTypeId { get; set; }
      public virtual EnumData FountainWaterSourceStabilityType { get; set; }
      public int? FountainWaterSourceStabilityTypeId { get; set; }
      public double? ExitVolumeMonthlyAverage { get; set; }
      public double? ConsumingVolumeMonthlyAverage { get; set; }
      public string Consumers { get; set; }
      public string VisualSpecification { get; set; }
      public bool? HasConsumptionMeter { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public string Description { get; set; }
      public virtual ICollection<FountainWaterUsage> WaterUsages { get; set; }
   }
}
