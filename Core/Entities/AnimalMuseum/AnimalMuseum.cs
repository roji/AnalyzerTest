using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class AnimalMuseum : IAuditableEntity
   {
      public int Id { get; set; }
      public string PersianName { get; set; }
      public string EnglishName { get; set; }
      public int? Repeats { get; set; }
      public string OldSampleCode { get; set; }
      public string NewSampleCode { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public string Elevation { get; set; }
      public double? LocationMaximumAltitude { get; set; }
      public double? LocationMinimumAltitude { get; set; }
      public virtual EnumData LocationAccuracy { get; set; }
      public int? LocationAccuracyId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData AnimalProtectedZone { get; set; }
      public int? AnimalProtectedZoneId { get; set; }
      public virtual EnumData AnimalLocation { get; set; }
      public int? AnimalLocationId { get; set; }
      public virtual EnumData AnimalKingdom { get; set; }
      public int? AnimalKingdomId { get; set; }
      public virtual EnumData AnimalPhylum { get; set; }
      public int? AnimalPhylumId { get; set; }
      public virtual EnumData AnimalClass { get; set; }
      public int? AnimalClassId { get; set; }
      public virtual EnumData AnimalOrder { get; set; }
      public int? AnimalOrderId { get; set; }
      public virtual EnumData AnimalFamily { get; set; }
      public int? AnimalFamilyId { get; set; }
      public virtual EnumData AnimalGenus { get; set; }
      public int? AnimalGenusId { get; set; }
      public virtual EnumData AnimalSpecies { get; set; }
      public int? AnimalSpeciesId { get; set; }
      public virtual EnumData AnimalSubSpecies { get; set; }
      public int? AnimalSubSpeciesId { get; set; }
      public virtual EnumData AnimalType { get; set; }
      public int? AnimalTypeId { get; set; }
      public virtual EnumData AnimalEcosystem { get; set; }
      public int? AnimalEcosystemId { get; set; }
      public virtual EnumData AnimalPreservation { get; set; }
      public int? AnimalPreservationId { get; set; }
      public virtual EnumData AnimalConservationStatus { get; set; }
      public int? AnimalConservationStatusId { get; set; }
      public string CollectorPersianName { get; set; }
      public string CollectorEnglishName { get; set; }
      public string DeterminatorPersianName { get; set; }
      public string DeterminatorEnglishName { get; set; }
      public string RevisionistPersianName { get; set; }
      public string RevisionistEnglishName { get; set; }
      public string TaxidermistPersianName { get; set; }
      public string TaxidermistEnglishName { get; set; }
      public string DescriptivePersianName { get; set; }
      public string DescriptiveEnglishName { get; set; }
      public int? RevisionDate { get; set; }
      public string BiometricInformation { get; set; }
      public string PreservationMethod { get; set; }
      public bool? IsNative { get; set; }
      public string Comments { get; set; }
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)] public string PhotoFileNameId { get; set; }
   }
}
