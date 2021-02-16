using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentCaseAdditionalInfo : IAccessControl, IAuditableEntity
   {
      public IndustryEstablishmentCaseAdditionalInfo()
      {
         Distances = new HashSet<IndustryEstablishmentCaseAdditionalInfoDistance>();
      }
      public int Id { get; set; }
      public int? RoadTypeId { get; set; }
      public virtual EnumData RoadType { get; set; }
      public string RoadTypeDescription { get; set; }
      public double? RoadWidth { get; set; }
      public double? RoadLength { get; set; }
      public string GroundShape { get; set; }
      public string WaterResourceStatus { get; set; }
      public string DustDepthAndType { get; set; }
      public string ClimateSituation { get; set; }
      public string VegetationCover { get; set; }
      public string StaticLevel { get; set; }
      public string AnimalDistribution { get; set; }
      public int? IntendedLandUsageId { get; set; }
      public virtual EnumData IntendedLandUsage { get; set; }
      public int? NeighborLandUsageId { get; set; }
      public virtual EnumData NeighborLandUsage { get; set; }
      public string InfrastructureBuildings { get; set; }
      public double? DistanceFromIndustrialTownAndRegion { get; set; }
      public string DistanceFromIndustrialTownAndRegionDescription { get; set; }
      public double? NorthDistanceFromResidentialUnits { get; set; }
      public double? SouthDistanceFromResidentialUnits { get; set; }
      public double? WestDistanceFromResidentialUnits { get; set; }
      public double? EastDistanceFromResidentialUnits { get; set; }
      public string DistanceFromResidentialUnitsDescription { get; set; }
      public string ImportantRelatedRulesAndCode { get; set; }
      public string OtherDescription { get; set; }
      public bool? IsSelectedPlaceInQuadrupleArea { get; set; }
      public virtual EnumData QuadrupleAreaType { get; set; }
      public int? QuadrupleAreaId { get; set; }
      public virtual EnumData QuadrupleArea { get; set; }
      public int? QuadrupleAreaTypeId { get; set; }
      public string QuadrupleAreaDescription { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public virtual ICollection<IndustryEstablishmentCaseAdditionalInfoDistance> Distances { get; set; }
   }
}
