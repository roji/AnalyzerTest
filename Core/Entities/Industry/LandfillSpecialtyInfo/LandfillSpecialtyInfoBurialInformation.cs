namespace Core.Entities
{
    public class LandfillSpecialtyInfoBurialInformation
    {
        public int Id { get; set; }
        public bool? WasteBurialPlaceObservedRules { get; set; }
        public string WasteBurialPlaceObservedRulesDescription { get; set; }
        public bool? BurialPlaceIsNotInRiverRange { get; set; }
        public string BurialPlaceIsNotInRiverRangeDescription { get; set; }
        public bool? BurialPlaceIsOutOfFloodRange { get; set; }
        public string BurialPlaceIsOutOfFloodRangeDescription { get; set; }
        public bool? BurialPlaceIsOutOfWetlands { get; set; }
        public string BurialPlaceIsOutOfWetlandsDescription { get; set; }
        public bool? BurialPlaceIsOutOfRegionWaterResource { get; set; }
        public string BurialPlaceIsOutOfRegionWaterResourceDescription { get; set; }
        public bool? BurialPlaceIsOutOfUndergoundWaterSupplies { get; set; }
        public string BurialPlaceIsOutOfUndergoundWaterSuppliesDescription { get; set; }
        public bool? BurialPlaceIsNotDamWater { get; set; }
        public string BurialPlaceIsNotDamWaterDescription { get; set; }
        public bool? BurialPlaceIsNotInAvalancheRegion { get; set; }
        public string BurialPlaceIsNotInAvalancheRegionDescription { get; set; }
        public bool? BurialPlaceIsNotInValleyRegion { get; set; }
        public string BurialPlaceIsNotInValleyRegionDescription { get; set; }
        public bool? BurialPlaceIsNoInActiveFaultRegion { get; set; }
        public string BurialPlaceIsNoInActiveFaultRegionDescription { get; set; }
        public bool? BurialPlaceSelectedRegionAreaObserveRules { get; set; }
        public string BurialPlaceSelectedRegionAreaObserveRulesDescription { get; set; }
        public bool? BurialPlaceIsNotInMineralResourcesRegion { get; set; }
        public string BurialPlaceIsNotInMineralResourcesRegionDescription { get; set; }
        public bool? BurialPlaceIsNotInDominantWindsRegion { get; set; }
        public string BurialPlaceIsNotInDominantWindsRegionDescription { get; set; }
        public bool? BurialPlaceIsNotInProtectedArea { get; set; }
        public string BurialPlaceIsNotInProtectedAreaDescription { get; set; }
        public bool? BurialPlaceAestheticsObserveRules { get; set; }
        public string BurialPlaceAestheticsObserveRulesDescription { get; set; }
        public bool? BurialPlaceRoadAccessWidthObserveRules { get; set; }
        public string BurialPlaceRoadAccessWidthObserveRulesDescription { get; set; }
        public bool? BurialPlaceHasMinimalTraffic { get; set; }
        public string BurialPlaceHasMinimalTrafficDescription { get; set; }
        public bool? BurialPlaceIsUsableInAllSeasons { get; set; }
        public string BurialPlaceIsUsableInAllSeasonsDescription { get; set; }
        public int LandfillSpecialtyInfoId { get; set; }
        public virtual LandfillSpecialtyInfo LandfillSpecialtyInfo { get; set; }
    }
}
