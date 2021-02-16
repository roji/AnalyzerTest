using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addMonitoringPollutionMapListView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_monitoringpollutionmaplist AS 
                SELECT
                Province.Title AS Province,
                EstablishmentGrouping.Title AS EstablishmentGrouping,
                industry_workshopaddresses.Latitude AS Latitude,
                industry_workshopaddresses.Longitude AS Longitude,
                industrialunitssamplingresults.MonitoringYear,
                MonitoringPeriod.Title AS MonitoringPeriodTitle,
                MonitoringPeriod.`Data` AS MonitoringPeriodData,
                industries.`Name` AS Industry,
                industries.Id AS IndustryId,
                industrialunitssamplingresults.Id,
                ( CASE WHEN ambientairparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity THEN 1 ELSE 0 END ) AS HasAmbientPollution,
                ( CASE WHEN chimneyparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity THEN 1 ELSE 0 END ) AS HasChimneyPollution,
                ( CASE WHEN wasteparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity THEN 1 ELSE 0 END ) AS HasWastePollution,
                ( CASE WHEN wastewaterparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity THEN 1 ELSE 0 END ) AS HasWastewaterPollution,
                ( CASE WHEN soundandwavesparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity THEN 1 ELSE 0 END ) AS HasSoundAndWavePollution,
                Param.Title AS ParamTitle 
            FROM
                industrialunitssamplingresults
                INNER JOIN industries ON industrialunitssamplingresults.IndustryId = industries.Id
                INNER JOIN industry_workshopaddresses ON industries.Id = industry_workshopaddresses.IndustryId
                INNER JOIN enumdata Province ON industry_workshopaddresses.ProvinceId = Province.Id
                JOIN parameterssamplingresults ON industrialunitssamplingresults.Id = parameterssamplingresults.IndustrialUnitsSamplingResultId
                INNER JOIN enumdata EstablishmentGrouping ON industries.EstablishmentGroupingId = EstablishmentGrouping.Id
                INNER JOIN enumdata MonitoringPeriod ON industrialunitssamplingresults.MonitoringPeriodId = MonitoringPeriod.Id
                INNER JOIN monitoringparameters MonitoringParameters ON parameterssamplingresults.MonitoringParametersId = monitoringparameters.Id
                LEFT JOIN ambientairparametersresults ON ambientairparametersresults.ParametersSamplingResultsId = parameterssamplingresults.Id
                LEFT JOIN chimneyparametersresults ON chimneyparametersresults.ParametersSamplingResultsId = parameterssamplingresults.Id
                LEFT JOIN wastewaterparametersresults ON wastewaterparametersresults.ParametersSamplingResultsId = parameterssamplingresults.Id
                LEFT JOIN wasteparametersresults ON wasteparametersresults.ParametersSamplingResultsId = parameterssamplingresults.Id
                LEFT JOIN soundandwavesparametersresults ON soundandwavesparametersresults.ParametersSamplingResultsId = parameterssamplingresults.Id
                LEFT JOIN enumdata Param ON monitoringparameters.ParamId = Param.Id 
                AND (
                    ambientairparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity 
                    OR chimneyparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity 
                    OR wasteparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity 
                    OR wastewaterparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity OR
                    soundandwavesparametersresults.Quantity > MonitoringParameters.PollutionLimitQuantity 
                ) 
            WHERE
                industrialunitssamplingresults.FinalSave = TRUE 
            GROUP BY
                industrialunitssamplingresults.Id,
                Param.Id";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_monitoringpollutionmaplist`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
