namespace Core.Entities
{
    public class LandfillSpecialtyInfoTemporaryHoldingInformation
    {
        public int Id { get; set; }
        public double? HoldingCapacity { get; set; }
        public bool? HasFencing { get; set; }
        public string FencingDescription { get; set; }
        public bool? HasProperFloorCoveringInStoragePlace { get; set; }
        public string ProperFloorCoveringInStoragePlaceDescription { get; set; }
        public bool? HasConcreteFlooring { get; set; }
        public string ConcreteFlooringDescription { get; set; }
        public bool? HasGeotextileFloorCovering { get; set; }
        public string GeotextileFloorCoveringDescription { get; set; }
        public bool? HasTwoCrushedClayLayer { get; set; }
        public string TwoCrushedClayLayerDescription { get; set; }
        public bool? HasDrainageBlanket { get; set; }
        public string DrainageBlanketDescription { get; set; }
        public bool? HasProperDrainageSystem { get; set; }
        public string ProperDrainageSystemDescription { get; set; }
        public bool? HasImpermeableWalls { get; set; }
        public string ImpermeableWallsDescription { get; set; }
        public bool? PutChemicalsTogetherProperly { get; set; }
        public string PutChemicalsTogetherProperlyDescription { get; set; }
        public bool? HasDoubleWalledPolyethyleneTanks { get; set; }
        public string DoubleWalledPolyethyleneTanksDescription { get; set; }
        public bool? HasSafetyEquipmentAndSupplies { get; set; }
        public string SafetyEquipmentAndSuppliesDescription { get; set; }
        public bool? HasFireAlarm { get; set; }
        public string FireAlarmDescription { get; set; }
        public bool? HasFireFighting { get; set; }
        public string FireFightingDescription { get; set; }
        public bool? HasFirstAid { get; set; }
        public string FirstAidDescription { get; set; }
        public int LandfillSpecialtyInfoId { get; set; }
        public virtual LandfillSpecialtyInfo LandfillSpecialtyInfo { get; set; }
    }
}
