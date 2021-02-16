using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentCase : IAccessControl, IAuditableEntity
   {
      public int Id { get; set; }
      public IndustryOwnershipTypes? OwnershipType { get; set; }
      public IndustryActivityTypes? ActivityType { get; set; }
      public bool? IsSmokeComingOutDuringActivity { get; set; }
      public string SmokeComingOutDuringActivityDescription { get; set; }
      public bool? IsGasComingOutDuringActivity { get; set; }
      public string GasComingOutDuringActivityDescription { get; set; }
      public bool? IsDustComingOutDuringActivity { get; set; }
      public string DustComingOutDuringActivityDescription { get; set; }
      public bool? IsIndustryActivityProduceAnnoyingSound { get; set; }
      public string IndustryActivityProduceAnnoyingSoundDescription { get; set; }
      public int? HowFarSoundIsNoticeable { get; set; }
      public string HowFarSoundIsNoticeableDescription { get; set; }
      public bool? IsIndustryActivityCreateVibration { get; set; }
      public string IndustryActivityCreateVibrationDescription { get; set; }
      public bool? IsIndustryActivityCreateRadiation { get; set; }
      public string IndustryActivityCreateRadiationDescription { get; set; }
      public IndustryGeographicalPositions? IndustryGeographicalPosition { get; set; }
      public bool? IsOutsideLegalRegion { get; set; }
      public IndustryGeographicalLocations? IndustryGeographicalLocation { get; set; }
      public double? DistanceFromEnvironmentalProtection { get; set; }
      public double? DistanceFromEducationalCenters { get; set; }
      public double? DistanceFromLawEnforcementCenters { get; set; }
      public double? DistanceFromHighwayTransitRoad { get; set; }
      public double? DistanceFromMainRoad { get; set; }
      public double? DistanceFromPark { get; set; }
      public double? DistanceFromLake { get; set; }
      public double? DistanceFromSea { get; set; }
      public double? DistanceFromNationalPark { get; set; }
      public double? DistanceFromProtectedAreas { get; set; }
      public double? DistanceFromWildlifeSanctuary { get; set; }
      public double? DistanceFromNationalNaturalEffect { get; set; }
      public double? DistanceFromPermanentRiver { get; set; }
      public double? DistanceFromExistingAqueduct { get; set; }
      public double? DistanceFromDrinkingWaterWells { get; set; }
      public double? DistanceFromAgriculturalWaterWells { get; set; }
      public double? DistanceFromIndustrialWaterWells { get; set; }
      public double? ChimneyOutputSpeedForecast { get; set; }
      public double? ChimneyOutputGasTemperature { get; set; }
      public double? ChimneyDominantWindSpeed { get; set; }
      public string ChimneyDominantWindDirection { get; set; }
      public virtual Upload CommitmentFileName { get; set; }

      [StringLength(38)] public string CommitmentFileNameId { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
   }

   public enum IndustryOwnershipTypes : int
   {
      [Display(Name = "دولتی")] Government = 1,

      [Display(Name = "نیمه دولتی")] SemiGovernment = 2,

      [Display(Name = "خصوصی")] Private = 3
   }

   public enum IndustryActivityTypes : int
   {
      [Display(Name = "دائمی")] Permanent = 1,

      [Display(Name = "فصلی")] Seasonal = 2,
   }
   public enum IndustryGeographicalPositions : int
   {
      [Display(Name = "خارج از محدوده شهری")] OutsideOfCityRegion = 1,

      [Display(Name = "خارج از محدوده خدماتی روستایی")] OutsideOfVillageRegion = 2,
   }
   public enum IndustryGeographicalLocations : int
   {
      [Display(Name = "واقع در شهرک صنعتی")] IndustrialTown = 1,

      [Display(Name = "ناحیه مسکونی")] ResidentialArea = 2,

      [Display(Name = "ناحیه تجاری و خدماتی")] CommercialArea = 3,

      [Display(Name = "ناحیه صنعتی")] IndustrialZone = 4,
   }
}
