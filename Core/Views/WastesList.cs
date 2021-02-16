using Core.Tools;

namespace Core.Entities
{
   public class WastesList
   {
      public string WasteNameTitle { get; set; }
      public int WasteNameId { get; set; }
      public string IndustryName { get; set; }
      public int IndustryId { get; set; }
      public string IsicCode4Title { get; set; }
      public int? IsicCode4Id { get; set; }
      public string IsicCode4Data { get; set; }
      public string EstablishmentGroupingTitle { get; set; }
      public int? EstablishmentGroupingId { get; set; }
      public int? EstablishmentGroupingClassificationId { get; set; }
      public string ProvinceTitle { get; set; }
      public int? ProvinceId { get; set; }
      public string StateTitle { get; set; }
      public int? StateId { get; set; }
      public int WasteId { get; set; }
      public int RealMountlyProduction { get; set; }
      public int AvailableQuantity { get; set; }
      public int VirtualMountlyProduction { get; set; }
      public WasteMeasurementUnits MeasurementUnit { get; set; }
      public string MeasurementUnitTitle => MeasurementUnit.GetDisplayNameAttribute();
      public int BaselABId { get; set; }
      public string BaselABTitle { get; set; }
      public int WasteClassificationId { get; set; }
      public string WasteClassificationTitle { get; set; }
   }
}
