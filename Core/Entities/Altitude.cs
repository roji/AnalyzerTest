using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Altitude : IAuditableEntity
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual Aquifer Aquifer { get; set; }
      public int? AquiferId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData AltitudeType { get; set; }
      public int? AltitudeTypeId { get; set; }
      public double? Area { get; set; }
      public double? Elevation { get; set; }
      public string PlantDescription { get; set; }
      public double? RainfallAnnualAverage { get; set; }
      public double? EvaporationAnnualAverage { get; set; }
      public double? UnauthorizedBlockedWellsQuantity { get; set; }
      public double? UnauthorizedBlockedWellsVolume { get; set; }
      public virtual ICollection<Aqueduct> Aqueducts { get; set; }
      public virtual ICollection<Pit> Pits { get; set; }
      public virtual ICollection<Fountain> Fountains { get; set; }
   }
}
