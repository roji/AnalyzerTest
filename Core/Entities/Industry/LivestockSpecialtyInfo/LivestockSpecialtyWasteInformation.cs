using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class LivestockSpecialtyWasteInformation
    {
        public int Id { get; set; }
        public double? SolidWasteQuantity { get; set; }
        public double? ProcessedSolidWasteQuantity { get; set; }
        public bool? HasSelfUsageSolidWaste { get; set; }
        public double? SelfUsageSolidWasteQuantity { get; set; }
        public bool? HasSavingInFutureSolidWaste { get; set; }
        public double? SavingInFutureSolidWasteQuantity { get; set; }
        public double? SavingInFitureSolidWasteStorageSize { get; set; }
        public bool? HasSolidWasteAssignedToFertilizerUnit { get; set; }
        public string SolidWasteFertilizerUnitName { get; set; }
        public virtual Upload SolidWasteFertilizerUnitContractFileName { get; set; }
        [StringLength(38)]
        public string SolidWasteFertilizerUnitContractFileNameId { get; set; }
        public bool? HasSolidWasteInOpenEnvironment { get; set; }
        public double? SolidWasteInOpenEnvironmentQuantity { get; set; }
        public string SolidWasteInOpenEnvioronmentKeepingPlace { get; set; }
        public double? LiquidWasteQuantity { get; set; }
        public double? ProcessedLiquidWasteQuantity { get; set; }
        public double? LiquidFertilizerExtraSize { get; set; }
        public bool? HasSelfUsageLiquidWaste { get; set; }
        public double? SelfUsageLiquidWasteQuantity { get; set; }
        public bool? HasSavingInFutureLiquidWaste { get; set; }
        public double? SavingInFutureLiquidWasteQuantity { get; set; }
        public double? SavingInFitureLiquidWasteStorageSize { get; set; }
        public bool? HasLiquidWasteAssignedToFertilizerUnit { get; set; }
        public string LiquidWasteFertilizerUnitName { get; set; }
        public virtual Upload LiquidWasteFertilizerUnitContractFileName { get; set; }
        [StringLength(38)]
        public string LiquidWasteFertilizerUnitContractFileNameId { get; set; }
        public bool? HasLiquidWasteSendingToRefinery { get; set; }
        public double? LiquidWasteSendingToRefineryQuantity { get; set; }
        public bool? HasLiquidWasteReleaseInOpenEnvironment { get; set; }
        public double? LiquidWasteReleaseInOpenEnvironmentQuantity { get; set; }
        public string LiquidWasteInOpenEnvioronmentReleasePlace { get; set; }
        public string LiquidWasteInOpenEnvioronmentPlaceType { get; set; }
        public int LivestockSpecialtyInfoId { get; set; }
        public virtual LivestockSpecialtyInfo LivestockSpecialtyInfo { get; set; }
    }
}
