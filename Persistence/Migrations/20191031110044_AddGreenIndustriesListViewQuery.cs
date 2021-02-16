using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddGreenIndustriesListViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_greenindustrieslist AS 
               SELECT
                    greenindustries.Id,
                    greenindustrystrategies.Id as GreenIndustryStrategyId,
                    greenindustries.FinalSave,
                    industries.Id AS IndustryId,
                    industries.EstablishmentGroupingId,
                    greenindustries.`Year`,
                    greenindustries.GreenIndustryStatus,
                    greenindustries.RequestDate,
                    greenindustries.ShowResultForIndustry,
                    greenindustrystrategies.IndicatorId,
                    greenindustrystrategies.CriterionId,
                    greenindustrystrategies.UnderCriteriaId,
                    greenindustrystrategies.StrategyId,
                    greenindustrystrategies.OrganizationExpertScore,
                    greenindustrystrategies.ProvinceExpertScore,
                    relations.Ratio,
                    relations.ScoreLimitation AS UnderCriteriaScoreLimitation,
                    industries.`Name` AS IndustryName,
                    Province.Title AS ProvinceTitle,
                    Province.Id AS ProvinceId,
                    Indicator.Title AS IndicatorTitle,
                    Criterion.Title AS CriterionTitle,
                    Criterion.`Data` AS CriterionScoreLimit,
                    UnderCriteria.Title AS UnderCriteriaTitle,
                    Strategy.Title AS StrategyTitle,
                    requestYear.`Data` As RequestYearGreenLimit,
                    requestYear.Category As RequestYearSelectedGreenLimit
                FROM
                    industries
                    INNER JOIN greenindustries ON greenindustries.IndustryId = industries.Id
                    LEFT JOIN greenindustrystrategies On greenindustries.Id = greenindustrystrategies.GreenIndustryId
                    LEFT JOIN enumdata as indicator on indicator.Id = greenindustrystrategies.IndicatorId
                    LEFT JOIN enumdata as criterion on criterion.Id = greenindustrystrategies.CriterionId
                    LEFT JOIN enumdata as underCriteria on underCriteria.Id = greenindustrystrategies.UnderCriteriaId
                    LEFT JOIN enumdata as strategy on strategy.Id = greenindustrystrategies.StrategyId
                    LEFT JOIN industry_workshopaddresses as address on address.IndustryId = industries.Id
                    LEFT JOIN enumdata as province on address.ProvinceId = province.Id
                    INNER JOIN enumdata as requestYear on greenindustries.`Year` = requestYear.Title
                    LEFT JOIN greenindustryrelations as relations on relations.EstablishmentGroupingId = industries.EstablishmentGroupingId
                    AND relations.UnderCriteriaId = underCriteria.Id";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_greenindustrieslist`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
