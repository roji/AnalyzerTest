using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class LivestockSpecialtyAdditionalInformation
    {
        public int Id { get; set; }
        public bool? HasUnderCultivationArea { get; set; }
        public double? UnderCultivationArea { get; set; }
        public string UnderCultivationSpecies { get; set; }
        public string ExpertFullName { get; set; }
        public string ExpertNationalCode { get; set; }
        public int? ExpertStartContractDate { get; set; }
        public int? ExpertEndContractDate { get; set; }
        public virtual Upload ExpertContractFileName { get; set; }
        [StringLength(38)]
        public string ExpertContractFileNameId { get; set; }
        public bool? IsThereAnyHospitalNear { get; set; }
        public string NearHospitals { get; set; }
        public bool? IsThereAnyAirportNear { get; set; }
        public string NearAirports { get; set; }
        public bool? IsThereAnyBarrackNear { get; set; }
        public string NearBarracks { get; set; }
        public bool? IsThereAnyRiverNear { get; set; }
        public string NearRivers { get; set; }
        public bool? IsThereAnySeaNear { get; set; }
        public string NearSeas { get; set; }
        public bool? IsThereAnyWetlandNear { get; set; }
        public string NearWetlands { get; set; }
        public bool? IsThereAnyFoodProductionUnitNear { get; set; }
        public string NearFoodProductionUnits { get; set; }
        public bool? IsThereAnyIndustrialUnitNear { get; set; }
        public string NearIndustrialUnits { get; set; }
        public string OtherNearUnits { get; set; }
        public double? UnderGroundWaterDistanceToGround { get; set; }
        public virtual EnumData SoilType { get; set; }
        public int? SoilTypeId { get; set; }
        public bool? AgreeToPeriodMonitoring { get; set; }
        public bool? AgreeToObservedTransportationRules { get; set; }
        public bool? AgreeToSectionNineInstruction { get; set; }
        public int LivestockSpecialtyInfoId { get; set; }
        public virtual LivestockSpecialtyInfo LivestockSpecialtyInfo { get; set; }
    }
}
