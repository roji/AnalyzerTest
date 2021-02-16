using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class PersonAddress : Contact
   {
      public virtual EnumData Province { get; set; }
      public virtual EnumData State { get; set; }
      public virtual EnumData City { get; set; }
      public int? ProvinceId { get; set; }
      public int? StateId { get; set; }
      public int? CityId { get; set; }
      public string AddressDetails { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public string ZipCode { get; set; }
   }
}
