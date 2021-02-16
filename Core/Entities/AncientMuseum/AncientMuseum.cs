using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class AncientMuseum : IAuditableEntity
   {
      public int Id { get; set; }
      public string SiteNumber { get; set; }
      public string UsingReference { get; set; }
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
      public virtual EnumData AncientProtectedZone { get; set; }
      public int? AncientProtectedZoneId { get; set; }
      public virtual EnumData AncientLocation { get; set; }
      public int? AncientLocationId { get; set; }
      public virtual EnumData AncientKingdom { get; set; }
      public int? AncientKingdomId { get; set; }
      public virtual EnumData AncientPhylum { get; set; }
      public int? AncientPhylumId { get; set; }
      public virtual EnumData AncientClass { get; set; }
      public int? AncientClassId { get; set; }
      public virtual EnumData AncientOrder { get; set; }
      public int? AncientOrderId { get; set; }
      public virtual EnumData AncientFamily { get; set; }
      public int? AncientFamilyId { get; set; }
      public virtual EnumData AncientSubFamily { get; set; }
      public int? AncientSubFamilyId { get; set; }
      public virtual EnumData AncientGenus { get; set; }
      public int? AncientGenusId { get; set; }
      public virtual EnumData AncientSpecies { get; set; }
      public int? AncientSpeciesId { get; set; }
      public virtual EnumData AncientType { get; set; }
      public int? AncientTypeId { get; set; }
      public virtual EnumData AncientAge { get; set; }
      public int? AncientAgeId { get; set; }
      public string CollectorPersianName { get; set; }
      public string CollectorEnglishName { get; set; }
      public string DeterminatorPersianName { get; set; }
      public string DeterminatorEnglishName { get; set; }
      public string RevisionistPersianName { get; set; }
      public string RevisionistEnglishName { get; set; }
      public int? RevisionDate { get; set; }
      public string DonatorPersianName { get; set; }
      public string DonatorEnglishName { get; set; }
      public int? DonateDate { get; set; }
      public bool HasForeignSample { get; set; }
      public string Comments { get; set; }
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)] public string PhotoFileNameId { get; set; }
   }
}
