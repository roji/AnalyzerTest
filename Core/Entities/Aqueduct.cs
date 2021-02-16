using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Aqueduct : IAuditableEntity
   {
      public Aqueduct()
      {
         Wells = new HashSet<AqueductWell>();
         WaterUsages = new HashSet<AqueductWaterUsage>();
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
      public virtual EnumData AqueductType { get; set; }
      public int? AqueductTypeId { get; set; }
      public virtual EnumData AqueductWaterSourceStabilityType { get; set; }
      public int? AqueductWaterSourceStabilityTypeId { get; set; }
      public double? ExitVolumeDailyAverage { get; set; }
      public double? ConsumingVolumeMonthlyAverage { get; set; }
      public string Consumers { get; set; }
      public string VisualSpecification { get; set; }
      public bool? HasConsumptionMeter { get; set; }
      public string Description { get; set; }
      public virtual ICollection<AqueductWell> Wells { get; set; }
      public virtual ICollection<AqueductWaterUsage> WaterUsages { get; set; }
   }
}
