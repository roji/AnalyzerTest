using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryNeedMonitoringDashboardViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_industryneedmonitoringdashboard AS 
               SELECT
                    Province.Title AS Province,
                    MonitoringTypes.Id AS MonitoringTypeId,
                    MonitoringTypes.Title AS MonitoringTypeTitle,
                    MonitoringTypes.Category AS Color,
                    Count(industries.Id) AS Count,
                    needmonitoringtypes.NeedMonitoring As NeedMonitoring
                    FROM
                    industries
                    INNER JOIN industry_workshopaddresses ON industries.Id = industry_workshopaddresses.IndustryId
                    INNER JOIN enumdata AS Province ON industry_workshopaddresses.ProvinceId = Province.Id
                    LEFT JOIN monitoringinfos ON industries.Id = monitoringinfos.IndustryId
                    LEFT JOIN needmonitoringtypes ON monitoringinfos.Id = needmonitoringtypes.MonitoringInfoId
                    LEFT JOIN enumdata MonitoringTypes ON MonitoringTypes.Id = needmonitoringtypes.MonitoringTypeId 
                GROUP BY
                    industry_workshopaddresses.ProvinceId,
                    MonitoringTypes.Id";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_industryneedmonitoringdashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
