using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class AddIsIndustryMonitoredMapListViewQuery : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var cmd = @"CREATE VIEW v_isindustrymonitoredmaplist AS
      select 
            industries.Id,
            industries.`Name`,
            industries.IsActive,
            province.Id as ProvinceId,
            province.Title as Province,
            state.Id as StateId,
            state.Title as State,
            address.Latitude,
            address.Longitude,
            establishmentGrouping.Id as EstablishmentGroupingId,
            establishmentGrouping.Title as EstablishmentGrouping,
            ( CASE WHEN iusr.Id IS NOT NULL THEN 1 ELSE 0 END ) AS HasMonitoring
            from industries 
            join industry_workshopaddresses address on address.IndustryId = industries.id
            left join enumdata province on province.Id = address.ProvinceId
            left join enumdata state on state.Id = address.StateId
            left join enumdata establishmentGrouping on establishmentGrouping.Id = industries.EstablishmentGroupingId
            left join industrialunitssamplingresults iusr on iusr.IndustryId = industries.Id and iusr.FinalSave = true
            GROUP BY industries.Id;";
         migrationBuilder.Sql(cmd);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         var cmd = @"DROP VIEW IF EXISTS `v_isindustrymonitoredmaplist`;";
         migrationBuilder.Sql(cmd);
      }
   }
}
