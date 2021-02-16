using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class SlaughterHouseSpecialtyInfo : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual EnumData SlaughterHouseClassification { get; set; }
      public int SlaughterHouseClassificationId { get; set; }
      public Int64 Capacity { get; set; }
      public bool? IsInSensitiveCentersWindDirection { get; set; }
      public string ScwdDescription { get; set; }
      public bool? IsInsideCity { get; set; }
      public int? DistanceFromCity { get; set; }
      public int? DistanceFromRiver { get; set; }
      public virtual EnumData LandType { get; set; }
      public int LandTypeId { get; set; }
      public QuarantineUnits? QuarantineUnit { get; set; }
      public string QuDescription { get; set; }
      public SeparationRecyclingBloods? SeparationRecyclingBlood { get; set; }
      public string SrbDescription { get; set; }
      public SeparationCleaningVisceras? SeparationCleaningViscera { get; set; }
      public string ScvDescription { get; set; }
      public FloorChannelsNetworks? FloorChannelsNetwork { get; set; }
      public string FcnDescription { get; set; }
      public WasteBakingUnits? WasteBakingUnit { get; set; }
      public string WbuDescription { get; set; }
      public BloodMeatPowderProductionUnits? BloodMeatPowderProductionUnit { get; set; }
      public string BmppuDescription { get; set; }
      public LivestockLossesWells? LivestockLossesWell { get; set; }
      public string LlwDescription { get; set; }
      public RespectiveBloodDirectionChannels? RespectiveBloodDirectionChannel { get; set; }
      public string RbdcDescription { get; set; }
      public BloodCollectionTanks? BloodCollectionTank { get; set; }
      public string BctDescription { get; set; }
      public string SensitiveSitesAroundSlaughterhouse { get; set; }
      public virtual Upload MinistryOfIndustryLicenseFileName { get; set; }

      [StringLength(38)]
      public string MinistryOfIndustryLicenseFileNameId { get; set; }
      public virtual Upload MinistryOfAgricultureLicenseFileName { get; set; }

      [StringLength(38)]
      public string MinistryOfAgricultureLicenseFileNameId { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
   }
   public enum QuarantineUnits : int
   {
      HasntQuarantineUnit = 0,
      HasQuarantineUnit = 1,
      NotNeedQuarantineUnit = 2
   }
   public enum SeparationRecyclingBloods : int
   {
      HasntSeparationRecyclingBlood = 0,
      HasSeparationRecyclingBlood = 1,
      NotNeedSeparationRecyclingBlood = 2
   }
   public enum SeparationCleaningVisceras : int
   {
      HasntSeparationCleaningViscera = 0,
      HasSeparationCleaningViscera = 1,
      NotNeedSeparationCleaningViscera = 2
   }
   public enum FloorChannelsNetworks : int
   {
      HasntFloorChannelsNetwork = 0,
      HasFloorChannelsNetwork = 1,
      NotNeedFloorChannelsNetwork = 2
   }
   public enum WasteBakingUnits : int
   {
      HasntWasteBakingUnit = 0,
      HasWasteBakingUnit = 1,
      NotNeedWasteBakingUnit = 2
   }
   public enum BloodMeatPowderProductionUnits : int
   {
      HasntBloodMeatPowderProductionUnit = 0,
      HasBloodMeatPowderProductionUnit = 1,
      NotNeedBloodMeatPowderProductionUnit = 2
   }
   public enum LivestockLossesWells : int
   {
      HasntLivestockLossesWell = 0,
      HasLivestockLossesWell = 1,
      NotNeedLivestockLossesWell = 2
   }
   public enum RespectiveBloodDirectionChannels : int
   {
      HasntRespectiveBloodDirectionChannel = 0,
      HasRespectiveBloodDirectionChannel = 1,
      NotNeedRespectiveBloodDirectionChannel = 2
   }
   public enum BloodCollectionTanks : int
   {
      HasntBloodCollectionTank = 0,
      HasBloodCollectionTank = 1,
      NotNeedBloodCollectionTank = 2
   }
}
