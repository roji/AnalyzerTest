using System;

namespace Core.Entities
{
   public class GreenIndustriesList
   {
      public int Id { get; set; }
      public int? GreenIndustryStrategyId { get; set; }
      public int IndustryId { get; set; }
      public int EstablishmentGroupingId { get; set; }
      public int Year { get; set; }
      public GreenIndustryStatuses GreenIndustryStatus { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public int? IndicatorId { get; set; }
      public int? CriterionId { get; set; }
      public int? UnderCriteriaId { get; set; }
      public int? StrategyId { get; set; }
      public double? OrganizationExpertScore { get; set; }
      public double? Ratio { get; set; }
      public double? UnderCriteriaScoreLimitation { get; set; }
      public string IndustryName { get; set; }
      public string ProvinceTitle { get; set; }
      public int ProvinceId { get; set; }
      public string IndicatorTitle { get; set; }
      public string CriterionTitle { get; set; }
      public string CriterionScoreLimit { get; set; }
      public string UnderCriteriaTitle { get; set; }
      public string StrategyTitle { get; set; }
      public string RequestYearGreenLimit { get; set; }
      public string RequestYearSelectedGreenLimit { get; set; }
      public double? ProvinceExpertScore { get; set; }
      public bool ShowResultForIndustry { get; set; }
   }
}
