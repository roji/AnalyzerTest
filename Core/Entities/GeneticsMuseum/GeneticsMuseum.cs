using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class GeneticsMuseum : IAuditableEntity
   {
      public int Id { get; set; }
      public string AnimalPersianName { get; set; }
      public string PlantPersianName { get; set; }
      public int? Repeats { get; set; }
      public string OldSampleCode { get; set; }
      public string NewSampleCode { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public string Elevation { get; set; }
      public double? LocationMaximumAltitude { get; set; }
      public double? LocationMinimumAltitude { get; set; }
      public int? CollectingDate { get; set; }
      public virtual EnumData LocationAccuracy { get; set; }
      public int? LocationAccuracyId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData GeneticsProtectedZone { get; set; }
      public int? GeneticsProtectedZoneId { get; set; }
      public virtual EnumData GeneticsLocation { get; set; }
      public int? GeneticsLocationId { get; set; }
      public virtual EnumData GeneticsKingdom { get; set; }
      public int? GeneticsKingdomId { get; set; }
      public virtual EnumData GeneticsPhylum { get; set; }
      public int? GeneticsPhylumId { get; set; }
      public virtual EnumData GeneticsClass { get; set; }
      public int? GeneticsClassId { get; set; }
      public virtual EnumData GeneticsOrder { get; set; }
      public int? GeneticsOrderId { get; set; }
      public virtual EnumData GeneticsFamily { get; set; }
      public int? GeneticsFamilyId { get; set; }
      public virtual EnumData GeneticsGenus { get; set; }
      public int? GeneticsGenusId { get; set; }
      public virtual EnumData GeneticsSpecies { get; set; }
      public int? GeneticsSpeciesId { get; set; }
      public virtual EnumData GeneticsSubSpecies { get; set; }
      public int? GeneticsSubSpeciesId { get; set; }
      public virtual EnumData GeneticsVariety { get; set; }
      public int? GeneticsVarietyId { get; set; }
      public virtual EnumData GeneticsType { get; set; }
      public int? GeneticsTypeId { get; set; }
      public virtual EnumData GeneticsSpecimenType { get; set; }
      public int? GeneticsSpecimenTypeId { get; set; }
      public virtual EnumData GeneticsQuality { get; set; }
      public int? GeneticsQualityId { get; set; }
      public virtual EnumData GeneticsConservationStatus { get; set; }
      public int? GeneticsConservationStatusId { get; set; }
      public string CollectorPersianName { get; set; }
      public string CollectorEnglishName { get; set; }
      public string DeterminatorPersianName { get; set; }
      public string DeterminatorEnglishName { get; set; }
      public string RevisionistPersianName { get; set; }
      public string RevisionistEnglishName { get; set; }
      public int? RevisionDate { get; set; }
      public string PreservationMethod { get; set; }
      public string Ambiguous { get; set; }
      public bool? IsMale { get; set; }
      public string Comments { get; set; }
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)] public string PhotoFileNameId { get; set; }
   }
}
