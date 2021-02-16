using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class BirdsSite : IAuditableEntity
   {
      public int Id { get; set; }
      public string PersianName { get; set; }
      public string EnglishName { get; set; }
      public virtual EnumData Province { get; set; }
      public int ProvinceId { get; set; }
      public virtual EnumData QuadrupleArea { get; set; }
      public int QuadrupleAreaId { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public double? Area { get; set; }
      public virtual ICollection<BirdsCensusSpecie> BirdsCensusSpecies { get; set; }
   }
}
