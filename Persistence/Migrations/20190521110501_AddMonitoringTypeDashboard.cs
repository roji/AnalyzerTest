using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringTypeDashboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_monitoringtypedashboard AS 
               SELECT
                    ( CASE WHEN isnull( `ostanenums`.`Title` ) THEN 'نامشخص' ELSE `ostanenums`.`Title` END ) AS `Province`,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 2802 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS AmbientAirMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 2909 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS RisklessMedicalDevices,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 2911 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS WastewaterMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 2912 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS WasteMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 2915 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS WaterResourceMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 2916 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS DustResourceMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 21555 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS MercuryAndHazardousChemicalsMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 22700 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS ChimneyMonitoring,
                    ( sum( CASE WHEN ( parameterssamplingresults.MonitoringTypeId = 22702 AND industrialunitssamplingresults.FinalSave = 1 ) THEN 1 ELSE 0 END ) ) AS SoundAndWavesMonitoring 
                FROM
                    `industries`
                    LEFT JOIN `industry_workshopaddresses` ON `industry_workshopaddresses`.`IndustryId` = `industries`.`Id`
                    LEFT JOIN `enumdata` `ostanenums` ON `industry_workshopaddresses`.`ProvinceId` = `ostanenums`.`Id`
                    LEFT JOIN industrialunitssamplingresults ON industrialunitssamplingresults.IndustryId = industries.Id
                    LEFT JOIN parameterssamplingresults ON parameterssamplingresults.IndustrialUnitsSamplingResultId = industrialunitssamplingresults.Id
                GROUP BY
                    `industry_workshopaddresses`.`ProvinceId`";
            migrationBuilder.Sql(cmd);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_monitoringtypedashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
