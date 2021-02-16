using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class WwHasPurificationSystems : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual Wastewater Wastewater { get; set; }
        public int WastewaterId { get; set; }
        //Purification PublicInfo
        public bool? PurificationSystemIsActive { get; set; }
        [NotMapped]
        public virtual ICollection<int> WastewaterPurificationSystemTypes { get; set; }
        public string WastewaterPurificationSystemTypeIds
        {
            get { return string.Join(",", WastewaterPurificationSystemTypes); }
            set { if (!string.IsNullOrWhiteSpace(value)) { WastewaterPurificationSystemTypes = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public string ManufacturerCompanyName { get; set; }
        public string HoldingCompanyName { get; set; }
        public int? SystemUsageValue { get; set; }
        public virtual EnumData SuvMeasurementUnit { get; set; }
        public int? SuvMeasurementUnitId { get; set; }
        public string SystemEstablishedYear { get; set; }
        public string SystemUpgradeYear { get; set; }
        public Int64? SystemBuildCost { get; set; }
        // Purification Public Sections
        public bool? HasDeaerator { get; set; }
        public string DeaeratorType { get; set; }
        public string DeaeratorDescription { get; set; }
        public bool? HasScreen { get; set; }
        public string ScreenDescription { get; set; }
        public bool? HasGritChamber { get; set; }
        public string GritChamberDescription { get; set; }
        public bool? HasBalancing { get; set; }
        public string BalancingDescription { get; set; }
        public bool? HasPrimarySedimentationPond { get; set; }
        public string PrimarySedimentationPondDescription { get; set; }
        public bool? HasSharpMixingPond { get; set; }
        public string SharpMixingPondDescription { get; set; }
        public bool? HasSlowMixingPond { get; set; }
        public string SlowMixingPondDescription { get; set; }
        public bool? HasSecondarySedimentationPond { get; set; }
        public string SecondarySedimentationPondDescription { get; set; }
        public bool? HasPressFilter { get; set; }
        public string PressFilterDescription { get; set; }
        public string PressFilterType { get; set; }
        public bool? HasSepticTank { get; set; }
        public string SepticTankDescription { get; set; }
        public string SepticTankType { get; set; }
        public bool? HasPolyethyleneTanks { get; set; }
        public string PolyethyleneTanksDescription { get; set; }
        public string PolyethyleneTanksType { get; set; }
        public bool? HasGreaseTrap { get; set; }
        public string GreaseTrapDescription { get; set; }
        public string GreaseTrapType { get; set; }
        public bool? HasWastewaterCollectionNetwork { get; set; }
        public string WastewaterCollectionNetworkDescription { get; set; }

        public bool? HasFlowmeter { get; set; }
        public string FlowmeterDescription { get; set; }
        public bool? HasAerationPond { get; set; }
        public string AerationPondDescription { get; set; }
        public bool? HasClearer { get; set; }
        public string ClearerDescription { get; set; }
        public bool? HasDisinfection { get; set; }
        public string DisinfectionDescription { get; set; }
        public bool? HasAdditionalSludgeStorageTank { get; set; }
        public string AdditionalSludgeStorageTankDescription { get; set; }
        public bool? HasReturningSludgePumpStation { get; set; }
        public string ReturningSludgePumpStationDescription { get; set; }
        public bool? HasOutputGasWashingTank { get; set; }
        public string OutputGasWashingTankDescription { get; set; }
        public bool? HasSludgeCondenser { get; set; }
        public string SludgeCondenserDescription { get; set; }
        public bool? HasSludgeDigester { get; set; }
        public string SludgeDigesterDescription { get; set; }
        public bool? HasEvaporationPonds { get; set; }
        public string EvaporationPondsDescription { get; set; }
        public bool? HasAnaerobicPonds { get; set; }
        public string AnaerobicPondsDescription { get; set; }
        public bool? HasFilteration { get; set; }
        public string FilterationDescription { get; set; }
        public bool? HasReverseOsmosis { get; set; }
        public string ReverseOsmosisDescription { get; set; }
        public bool? HasRefinedWastewaterStorageTank { get; set; }
        public string RefinedWastewaterStorageTankDescription { get; set; }
        // wastewater output analayse
        public int? RefineryOutputAnalyzeResultDate { get; set; }
        public string RefineryOutputAnalyzeResult { get; set; }
        // output Raw sludge section
        public bool? HasSludgePurification { get; set; }
        public bool? UsedForBiologicalFertilizer { get; set; }
        public bool? IsWastedAndRecorded { get; set; }
        public string SludgePurificationDescription { get; set; }
        public bool? RawSludgeNature { get; set; } // 0 For Chemical , 1 For Biological
        public bool? RawSludgeHasDangerous { get; set; }
        [NotMapped]
        public ICollection<int> RawSludgeHasDangerousProperties { get; set; }
        public string RawSludgeHasDangerousPropertiesIds
        {
            get { return string.Join(",", RawSludgeHasDangerousProperties); }
            set { if (!string.IsNullOrWhiteSpace(value)) { RawSludgeHasDangerousProperties = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public int? DailyRawSludgeOutputQuantity { get; set; }
        public virtual EnumData DrsoqMeasurementUnit { get; set; }
        public int? DrsoqMeasurementUnitId { get; set; }
        public int? MonthlyRawSludgeOutputQuantity { get; set; }
        public virtual EnumData MrsoqMeasurementUnit { get; set; }
        public int? MrsoqMeasurementUnitId { get; set; }
        public int? YearlyRawSludgeOutputQuantity { get; set; }
        public virtual EnumData YrsoqMeasurementUnit { get; set; }
        public int? YrsoqMeasurementUnitId { get; set; }
        public bool? HasSludgeCollectionUnit { get; set; }
        public int? SludgeCollectionUnitCapacity { get; set; }
        public virtual EnumData SludgeCollectionMeasurementUnit { get; set; }
        public int? SludgeCollectionMeasurementUnitId { get; set; }
        public string PurificationQualityQuantityBasics { get; set; }
        public string RawSludgeAnalyzeResult { get; set; }
        public string RefinedSludgeAnalyzeResult { get; set; }
        public virtual Upload PlanSiteFileName { get; set; }
        [StringLength(38)]
        public string PlanSiteFileNameId { get; set; }
        public virtual Upload RefineryHydraulicPlanFileName { get; set; }
        [StringLength(38)]
        public string RefineryHydraulicPlanFileNameId { get; set; }
        public WwHasPurificationSystems()
        {
            RawSludgeHasDangerousProperties = new List<int>();
            WastewaterPurificationSystemTypes = new List<int>();
        }
    }
}
