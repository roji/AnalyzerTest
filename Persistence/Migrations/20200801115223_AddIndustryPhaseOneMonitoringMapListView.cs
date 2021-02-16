using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class AddIndustryPhaseOneMonitoringMapListView : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var cmd = @"CREATE VIEW v_industryphaseonemonitoringmaplist AS 
               SELECT
                  industries.Id AS IndustryId,
                  industries.`Name` AS IndustryName,
                  industries.IsActive AS IsActive,
                  address.Latitude,
                  address.Longitude,
                  province.Id AS ProvinceId,
                  province.Title AS Province,
                  state.Id AS StateId,
                  state.Title AS State,
                  isic2.`Id` AS IsicCode2Id,
                  isic4.`Id` AS IsicCode4Id,
                  isic4.Title AS IsicCode4,
                  industries.LastUpdateDateTime AS LastUpdateDateTime,
                  ( CASE WHEN needmonitoringtypes.Id IS NOT NULL THEN 1 ELSE 0 END ) AS HasNeedMonitoring 
               FROM
                  industries
                  LEFT JOIN monitoringinfos ON monitoringinfos.IndustryId = industries.Id
                  LEFT JOIN needmonitoringtypes ON needmonitoringtypes.MonitoringInfoId = monitoringinfos.Id
                  LEFT JOIN industry_workshopaddresses address ON address.IndustryId = industries.Id
                  LEFT JOIN enumdata province ON province.Id = address.ProvinceId
                  LEFT JOIN enumdata state ON state.Id = address.StateId
                  LEFT JOIN enumdata isic4 ON isic4.Id = industries.IsicCodeId
                  LEFT JOIN enumdata isic2 ON isic2.Id = isic4.ParentId 
               WHERE
                  isic4.`Data` IN (
                     1520,
                     2101,
                     2429,
                     2423,
                     2813,
                     2731,
                     2732,
                     2710,
                     2720,
                     1320,
                     1310,
                     2413,
                     2412,
                     2411,
                     2421,
                     2422,
                     2694,
                     2610,
                     1542,
                     3110,
                     3420,
                     1514,
                     2221,
                     8511,
                     1712,
                     9303 
                  ) 
                  OR isic2.`Data` IN ( 90, 37, 10, 11, 77, 23, 40, 41, 16 ) 
               GROUP BY
                  industries.Id 
               ORDER BY
                  LastUpdateDateTime DESC;";
         migrationBuilder.Sql(cmd);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         var cmd = @"DROP VIEW IF EXISTS `v_industryphaseonemonitoringmaplist`;";
         migrationBuilder.Sql(cmd);
      }
   }
}
