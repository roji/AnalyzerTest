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
   public class WaterConsumption : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public bool HasCityOrVillageWater { get; set; }
      public string CvSupplySourceLocationName { get; set; }
      public int? CvSpringAverageConsumption { get; set; }
      public int? CvSummerAverageConsumption { get; set; }
      public int? CvAutumnAverageConsumption { get; set; }
      public int? CvWinterAverageConsumption { get; set; }
      public bool HasGroundWater { get; set; }
      public string GwSupplySourceLocationName { get; set; }
      public int? GwSpringAverageConsumption { get; set; }
      public int? GwSummerAverageConsumption { get; set; }
      public int? GwAutumnAverageConsumption { get; set; }
      public int? GwWinterAverageConsumption { get; set; }
      public bool HasSurfaceWater { get; set; }
      public string SwSupplySourceLocationName { get; set; }
      public int? SwSpringAverageConsumption { get; set; }
      public int? SwSummerAverageConsumption { get; set; }
      public int? SwAutumnAverageConsumption { get; set; }
      public int? SwWinterAverageConsumption { get; set; }
      public bool HasSeaWater { get; set; }
      public string SeawSupplySourceLocationName { get; set; }
      public int? SeawSpringAverageConsumption { get; set; }
      public int? SeawSummerAverageConsumption { get; set; }
      public int? SeawAutumnAverageConsumption { get; set; }
      public int? SeawWinterAverageConsumption { get; set; }

      [NotMapped]
      public ICollection<int> CwConsumptionPlaces { get; set; }
      public string CwConsumptionPlacesIds
      {
         get { return string.Join(",", CwConsumptionPlaces); }
         set { if (!string.IsNullOrWhiteSpace(value)) { CwConsumptionPlaces = value.Split(',').Select(int.Parse).ToList(); } }

      }

      [NotMapped]
      public ICollection<int> GwConsumptionPlaces { get; set; }
      public string GwConsumptionPlacesIds
      {
         get { return string.Join(",", GwConsumptionPlaces); }
         set { if (!string.IsNullOrWhiteSpace(value)) { GwConsumptionPlaces = value.Split(',').Select(int.Parse).ToList(); } }

      }

      [NotMapped]
      public ICollection<int> SwConsumptionPlaces { get; set; }
      public string SwConsumptionPlacesIds
      {
         get { return string.Join(",", SwConsumptionPlaces); }
         set { if (!string.IsNullOrWhiteSpace(value)) { SwConsumptionPlaces = value.Split(',').Select(int.Parse).ToList(); } }

      }

      [NotMapped]
      public ICollection<int> SeawConsumptionPlaces { get; set; }
      public string SeawConsumptionPlacesIds
      {
         get { return string.Join(",", SeawConsumptionPlaces); }
         set { if (!string.IsNullOrWhiteSpace(value)) { SeawConsumptionPlaces = value.Split(',').Select(int.Parse).ToList(); } }

      }
      public string Description { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public int Year { get; set; }
      public bool? GeneralManagerVote { get; set; }
      public string GeneralManagerDescription { get; set; }
      public virtual User GeneralManagerUser { get; set; }
      public int? GeneralManagerUserId { get; set; }
      public bool? ApprovingOrganizationVote { get; set; }
      public string ApprovingOrganizationDescription { get; set; }
      public virtual User ApprovingOrganizationUser { get; set; }
      public int? ApprovingOrganizationUserId { get; set; }
      public DateTimeOffset? GeneralManagerVoteDateTime { get; set; }
      public DateTimeOffset? ApprovingOrganizationVoteDateTime { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)] public string DocumentFileNameId { get; set; }
      public WaterConsumption()
      {
         CwConsumptionPlaces = new List<int>();
         GwConsumptionPlaces = new List<int>();
         SwConsumptionPlaces = new List<int>();
         SeawConsumptionPlaces = new List<int>();
      }
   }
}
