using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HerbalMuseum : IAuditableEntity
   {
      public int Id { get; set; }
      public string PlantName { get; set; }
      public int? Repeats { get; set; }
      public string OldSampleCode { get; set; }
      public string NewSampleCode { get; set; }
      public int? CollectingDate { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public string Elevation { get; set; }
      public double? LocationMaximumAltitude { get; set; }
      public double? LocationMinimumAltitude { get; set; }
      public bool HasForeignSample { get; set; }
      public virtual EnumData LocationAccuracy { get; set; }
      public int? LocationAccuracyId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData HerbalProtectedZone { get; set; }
      public int? HerbalProtectedZoneId { get; set; }
      public virtual EnumData HerbalLocation { get; set; }
      public int? HerbalLocationId { get; set; }
      public virtual EnumData HerbalKingdom { get; set; }
      public int? HerbalKingdomId { get; set; }
      public virtual EnumData HerbalPhylum { get; set; }
      public int? HerbalPhylumId { get; set; }
      public virtual EnumData HerbalClass { get; set; }
      public int? HerbalClassId { get; set; }
      public virtual EnumData HerbalOrder { get; set; }
      public int? HerbalOrderId { get; set; }
      public virtual EnumData HerbalFamily { get; set; }
      public int? HerbalFamilyId { get; set; }
      public virtual EnumData HerbalGenus { get; set; }
      public int? HerbalGenusId { get; set; }
      public virtual EnumData HerbalSpecies { get; set; }
      public int? HerbalSpeciesId { get; set; }
      public virtual EnumData HerbalSubSpecies { get; set; }
      public int? HerbalSubSpeciesId { get; set; }
      public virtual EnumData HerbalVariety { get; set; }
      public int? HerbalVarietyId { get; set; }
      public virtual EnumData HerbalType { get; set; }
      public int? HerbalTypeId { get; set; }
      public virtual EnumData HerbalEcosystem { get; set; }
      public int? HerbalEcosystemId { get; set; }
      public virtual EnumData HerbalTopography { get; set; }
      public int? HerbalTopographyId { get; set; }
      public virtual EnumData HerbalSoilType { get; set; }
      public int? HerbalSoilTypeId { get; set; }
      public virtual EnumData HerbalLifeForm { get; set; }
      public int? HerbalLifeFormId { get; set; }
      public virtual EnumData HerbalChoroType { get; set; }
      public int? HerbalChoroTypeId { get; set; }
      public virtual EnumData HerbalConservationStatus { get; set; }
      public int? HerbalConservationStatusId { get; set; }
      // public virtual ICollection<HerbalMuseumRevelator> Revelators { get; set; }
      public string CollectorPersianName { get; set; }
      public string CollectorEnglishName { get; set; }
      public string DeterminatorPersianName { get; set; }
      public string DeterminatorEnglishName { get; set; }
      public string RevisionistPersianName { get; set; }
      public string RevisionistEnglishName { get; set; }
      public int? RevisionDate { get; set; }
      public string Comments { get; set; }
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)] public string PhotoFileNameId { get; set; }

      // public HerbalMuseum()
      // {
      // Revelators = new HashSet<HerbalMuseumRevelator>();
      // }
   }
   // public class HerbalMuseumRevelator : IAuditableEntity
   // {
   //    public int Id { get; set; }
   //    public string PersianFullName { get; set; }
   //    public string EnglishFullName { get; set; }
   //    public HerbalMuseumRevelatorTypes Type { get; set; }
   //    public int? Date { get; set; }
   //    public virtual HerbalMuseum HerbalMuseum { get; set; }
   //    public int HerbalMuseumId { get; set; }
   // }
   // public enum HerbalMuseumRevelatorTypes : int
   // {
   //    Collector = 1,
   //    Determinator = 2,
   //    Revision = 3
   // }
}
