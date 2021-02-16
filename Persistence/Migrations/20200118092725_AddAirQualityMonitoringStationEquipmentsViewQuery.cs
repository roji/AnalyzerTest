using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAirQualityMonitoringStationEquipmentsViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_airqualitymonitoringstationequipmentsmaplist AS 
                    SELECT
	airqualitymonitoringstations.Id,
	airqualitymonitoringstations.`Name`,
	airqualitymonitoringstations.NeededCostsToMeetRequirements,
	airqualitymonitoringstations.IsActive,
	airqualitymonitoringstation_addresses.Latitude,
	airqualitymonitoringstation_addresses.Longitude,
	Province.Title AS Province,
	Province.Id AS ProvinceId,
	GROUP_CONCAT( DISTINCT Parameter.Title SEPARATOR "" - "" ) AS Parameter,

    GROUP_CONCAT(DISTINCT SparePart.Title SEPARATOR "" - "") AS SparePart,
  GROUP_CONCAT( DISTINCT Consumable.Title SEPARATOR "" - "" ) AS Consumable,
  t1.Total
FROM

    airqualitymonitoringstations
    LEFT JOIN airqualitymonitoringstation_addresses ON airqualitymonitoringstation_addresses.AirQualityMonitoringStationId = airqualitymonitoringstations.Id

    LEFT JOIN airqualitystationparametersanalyzers ON airqualitymonitoringstations.Id = airqualitystationparametersanalyzers.AirQualityMonitoringStationId

    LEFT JOIN airqualitystationconsumables ON airqualitystationparametersanalyzers.Id = airqualitystationconsumables.AirQualityStationParametersAnalyzerId

    LEFT JOIN airqualitystationspareparts ON airqualitystationparametersanalyzers.Id = airqualitystationspareparts.AirQualityStationParametersAnalyzerId

    LEFT JOIN enumdata AS Parameter ON airqualitystationparametersanalyzers.AirQualityMonitoringStationParameterId = Parameter.Id

    LEFT JOIN enumdata AS SparePart ON airqualitystationspareparts.StationSparePartId = SparePart.Id

    LEFT JOIN enumdata AS Consumable ON airqualitystationconsumables.StationConsumableId = Consumable.Id

    LEFT JOIN enumdata AS Province ON airqualitymonitoringstation_addresses.ProvinceId = Province.Id

    LEFT JOIN(
    SELECT
        SUM(NeededCostsToMeetRequirements ) AS total,
        airqualitymonitoringstation_addresses.ProvinceId AS Pid
    FROM

        airqualitymonitoringstations
        JOIN airqualitymonitoringstation_addresses ON airqualitymonitoringstation_addresses.AirQualityMonitoringStationId = airqualitymonitoringstations.Id

    GROUP BY

        airqualitymonitoringstation_addresses.ProvinceId

    ) AS t1 ON t1.Pid = airqualitymonitoringstation_addresses.ProvinceId
GROUP BY

    airqualitymonitoringstations.Id
            ";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_airqualitymonitoringstationequipmentsmaplist`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
