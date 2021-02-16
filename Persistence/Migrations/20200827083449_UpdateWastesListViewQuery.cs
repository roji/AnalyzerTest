using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class UpdateWastesListViewQuery : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var deleteCmd = @"DROP VIEW IF EXISTS `v_wasteslist`;";
         migrationBuilder.Sql(deleteCmd);

         var cmd = @"CREATE VIEW v_wasteslist AS 
               SELECT
                  WasteName.Title AS WasteNameTitle,
                  WasteName.Id AS WasteNameId,
                  industries.`Name` AS IndustryName,
                  industries.Id AS IndustryId,
                  IsicCode4.Title AS IsicCode4Title,
                  IsicCode4.Id AS IsicCode4Id,
                  IsicCode4.`Data` AS IsicCode4Data,
                  EstablishmentGrouping.Title AS EstablishmentGroupingTitle,
                  EstablishmentGrouping.Id AS EstablishmentGroupingId,
                  EstablishmentGrouping.ParentId AS EstablishmentGroupingClassificationId,
                  Province.Title AS ProvinceTitle,
                  Province.Id AS ProvinceId,
                  State.Title AS StateTitle,
                  State.Id AS StateId,
                  wastes.Id AS WasteId,
                  wastes.RealMountlyProduction,
                  wastes.AvailableQuantity,
                  wastes.VirtualMountlyProduction,
                  wastes.MeasurementUnit AS MeasurementUnit,
                  BaselAB.Id AS BaselABId,
                     BaselAB.Title AS BaselABTitle,
                  WasteClassification.Title AS WasteClassificationTitle,
                  WasteClassification.Id AS WasteClassificationId 
               FROM
                  wastes
                  JOIN wastecodings ON wastes.WasteCodingId = wastecodings.Id
                  JOIN industries ON wastes.IndustryId = industries.Id
                  JOIN industry_workshopaddresses ON industries.Id = industry_workshopaddresses.IndustryId
                  LEFT JOIN enumdata Province ON industry_workshopaddresses.ProvinceId = Province.Id
                  LEFT JOIN enumdata State ON industry_workshopaddresses.StateId = State.Id
                  LEFT JOIN enumdata EstablishmentGrouping ON industries.EstablishmentGroupingId = EstablishmentGrouping.Id
                  LEFT JOIN enumdata IsicCode4 ON industries.IsicCodeId = IsicCode4.Id
                  LEFT JOIN enumdata WasteName ON wastecodings.WasteNameId = WasteName.Id
                  LEFT JOIN enumdata WasteClassification ON wastecodings.WasteClassificationId = WasteClassification.Id
                  LEFT JOIN enumdata BaselAB ON wastecodings.BaselAbId = BaselAB.Id";
         migrationBuilder.Sql(cmd);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         var deleteCmd = @"DROP VIEW IF EXISTS `v_wasteslist`;";
         migrationBuilder.Sql(deleteCmd);
      }
   }
}
