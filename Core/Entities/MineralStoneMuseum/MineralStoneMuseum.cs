using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class MineralStoneMuseum : IAuditableEntity
   {
      public int Id { get; set; }
      public string Name { get; set; }
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
      public virtual EnumData MineralStoneProtectedZone { get; set; }
      public int? MineralStoneProtectedZoneId { get; set; }
      public virtual EnumData MineralStoneLocation { get; set; }
      public int? MineralStoneLocationId { get; set; }
      public virtual EnumData MineralStoneMineralType { get; set; }
      public int? MineralStoneMineralTypeId { get; set; }
      public virtual EnumData MineralStoneStoneType { get; set; }
      public int? MineralStoneStoneTypeId { get; set; }
      public virtual EnumData MineralStoneHardness { get; set; }
      public int? MineralStoneHardnessId { get; set; }
      public virtual EnumData MineralStoneCrystallizationSystem { get; set; }
      public int? MineralStoneCrystallizationSystemId { get; set; }
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
      public string Comments { get; set; }
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)] public string PhotoFileNameId { get; set; }
   }
}
