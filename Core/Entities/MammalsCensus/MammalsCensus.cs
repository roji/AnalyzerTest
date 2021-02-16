using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class MammalsCensus : IAuditableEntity
   {
      public MammalsCensus()
      {
         Species = new HashSet<MammalsCensusSpecie>();
         Persons = new HashSet<MammalsCensusPerson>();
      }
      public int Id { get; set; }
      public int Date { get; set; }
      public string Offers { get; set; }
      public string OperationalStrengths { get; set; }
      public string OperationalWeaknesses { get; set; }
      public int QuadrupleAreaId { get; set; }
      public virtual EnumData QuadrupleArea { get; set; }
      public double? CensusArea { get; set; }
      public string Description { get; set; }
      // Files
      public virtual Upload RationalTopographyMapFileName { get; set; }

      [StringLength(38)]
      public string RationalTopographyMapFileNameId { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public virtual ICollection<MammalsCensusSpecie> Species { get; set; }
      public virtual ICollection<MammalsCensusPerson> Persons { get; set; }

   }
}
