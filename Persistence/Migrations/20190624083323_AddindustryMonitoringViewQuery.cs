using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddindustryMonitoringViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_industrymonitoringmaplist AS 
                 SELECT
                    industries.Id AS IndustryId,
                    industries.`Name` AS IndustryName,
                    industry_workshopaddresses.Longitude As Geo_Longitude,
                    industry_workshopaddresses.Latitude As Geo_Latitude,
                    Province.Title AS ProvinceTitle,
                    industrialunitssamplingresults.MonitoringYear,
                    (Case WHEN industrialunitssamplingresults.MonitoringPeriodId = 22591 then 1 else 0 end) as FirstPeriod,
                    (Case WHEN industrialunitssamplingresults.MonitoringPeriodId = 22592 then 1 else 0 end) as SecondPeriod,
                    (Case WHEN industrialunitssamplingresults.MonitoringPeriodId = 22593 then 1 else 0 end) as ThirdPeriod,
                    (Case WHEN industrialunitssamplingresults.MonitoringPeriodId = 22594 then 1 else 0 end) as FourthPeriod,
                    MonitoringTypes.Id as MonitoringTypeId,
                    MonitoringTypes.Title as MonitoringTypeTitle,
                    MonitoringTypes.`Data` AS MonitoringTypeClassification,
                    (CASE When isnull(MonitoringYear) then 0 else 1 end) As MonitoringDone
                    FROM
                    industries
                    INNER JOIN industry_workshopaddresses ON industries.Id = industry_workshopaddresses.IndustryId
                    INNER JOIN enumdata AS Province ON industry_workshopaddresses.ProvinceId = Province.Id
                    LEFT JOIN industrialunitssamplingresults ON industrialunitssamplingresults.IndustryId = industries.Id and industrialunitssamplingresults.FinalSave = 1
                    LEFT JOIN monitoringinfos on industries.Id = monitoringinfos.IndustryId
                    LEFT JOIN needmonitoringtypes on monitoringinfos.Id = needmonitoringtypes.MonitoringInfoId
                    LEFT JOIN enumdata MonitoringTypes On MonitoringTypes.Id = needmonitoringtypes.MonitoringTypeId
                    where needmonitoringtypes.NeedMonitoring = 1
                    GROUP BY
                    industry_workshopaddresses.ProvinceId,
                    industrialunitssamplingresults.MonitoringYear,
                    MonitoringTypes.Id";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_industrymonitoringmaplist`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
