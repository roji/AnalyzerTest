using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Waste : IAuditableEntity, IAccessControl
   {
      public Waste()
      {
         NormalWasteInformation = new NormalWasteInformation();
         MaterialModes = new HashSet<WasteMaterialMode>();
         KeepingMethods = new HashSet<WasteKeepingMethod>();
         CollectMethods = new HashSet<WasteCollectMethod>();
      }
      public int Id { get; set; }
      public int? VirtualMountlyProduction { get; set; }
      public int? RealMountlyProduction { get; set; }
      public int? AvailableQuantity { get; set; }
      public string MethodDescription { get; set; }
      public string IwriuDescription { get; set; }
      public int? RepositoryId { get; set; }
      public virtual Repository Repository { get; set; }
      public int? ProduceFrequencyId { get; set; }
      public virtual EnumData ProduceFrequency { get; set; }
      public int? ProducedWasteLocationId { get; set; }
      public virtual EnumData ProducedWasteLocation { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public int WasteCodingId { get; set; }
      public virtual WasteCoding WasteCoding { get; set; }
      public virtual NormalWasteInformation NormalWasteInformation { get; set; }
      public virtual ICollection<WasteMaterialMode> MaterialModes { get; set; }
      public virtual ICollection<WasteKeepingMethod> KeepingMethods { get; set; }
      public virtual ICollection<WasteCollectMethod> CollectMethods { get; set; }
      public double? BurnPercentage { get; set; }
      public double? RecyclePercentage { get; set; }
      public double? SalePercentage { get; set; }
      public double? BurialPercentage { get; set; }
      public double? PilingUpPercentage { get; set; }
      public double? TransferToAuthorizedCenterPercentage { get; set; }
      public WasteMeasurementUnits MeasurementUnit { get; set; }
   }

   public enum WasteMeasurementUnits : int
   {
      [Display(Name = "کیلوگرم")] Kilogram = 2,

      [Display(Name = "لیتر")] Litre = 3
   }
}
