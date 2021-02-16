using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class AddWasteSenderIndustryMapListViewQuery : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var cmd = @"CREATE VIEW v_wastesenderindustrymaplist AS
            SELECT
               SenderProvince.Id as SenderProvinceId,
               SenderProvince.Title As SenderProvince,
               SenderState.Id as SenderStateId,
               SenderState.Title as SenderState,
               SenderIndustry.`Name` as SenderIndustry,
               SenderIndustry.Id as SenderIndustryId,
               EstablishmentGrouping.Id as EstablishmentGroupingId,
               EstablishmentGrouping.Title as EstablishmentGrouping,
               GROUP_CONCAT( DISTINCT WasteName.Title SEPARATOR "" - "" ) AS WasteNames,
               SenderIndustryAddress.Latitude,
               SenderIndustryAddress.Longitude
               FROM
                  wastetransfers
                  JOIN wastes on wastes.Id = wastetransfers.WasteId
                  JOIN wastecodings on wastecodings.Id = wastes.WasteCodingId
                  JOIN industries SenderIndustry ON wastetransfers.SenderIndustryId = SenderIndustry.Id 
                  JOIN industry_workshopaddresses SenderIndustryAddress ON SenderIndustry.Id = SenderIndustryAddress.IndustryId 
                  LEFT JOIN enumdata SenderProvince on SenderProvince.Id = SenderIndustryAddress.ProvinceId
                  LEFT JOIN enumdata SenderState on SenderState.Id = SenderIndustryAddress.StateId
                  LEFT JOIN enumdata EstablishmentGrouping on EstablishmentGrouping.Id = SenderIndustry.EstablishmentGroupingId
                  LEFT JOIN enumdata WasteName on WasteName.Id = wastecodings.WasteNameId
                  WHERE wastetransfers.IsDeleted = False 
                  GROUP BY SenderIndustryId";
         migrationBuilder.Sql(cmd);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         var cmd = @"DROP VIEW IF EXISTS `v_wastesenderindustrymaplist`;";
         migrationBuilder.Sql(cmd);
      }
   }
}
