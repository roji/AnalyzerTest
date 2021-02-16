using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class BirdsCensus : IAuditableEntity
   {
      public BirdsCensus()
      {
         Species = new HashSet<BirdsCensusSpecie>();
         Persons = new HashSet<BirdsCensusPerson>();
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
      public virtual ICollection<BirdsCensusSpecie> Species { get; set; }
      public virtual ICollection<BirdsCensusPerson> Persons { get; set; }

   }
}
