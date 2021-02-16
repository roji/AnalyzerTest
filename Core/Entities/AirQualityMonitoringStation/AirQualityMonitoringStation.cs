using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class AirQualityMonitoringStation : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Person Manager { get; set; }
        public virtual Address StationAddress { get; set; }
        public int? InstallationYear { get; set; }
        public int? LaunchingYear { get; set; }
        public int? StationTypeId { get; set; }
        public virtual EnumData StationType { get; set; }
        public int? StationDataSendingFrequencyId { get; set; }
        public virtual EnumData StationDataSendingFrequency { get; set; }
        public bool IsActive { get; set; }
        public string WhyNotActiveDescription { get; set; }
        public bool? MonitoringBoard { get; set; }
        public virtual StationKeepingStatuses? StationKeepingStatus { get; set; }
        // Keeping Contract
        public string ContractorName { get; set; }
        public string ContractorPhone { get; set; }
        public int? ContractStartDate { get; set; }
        public int? ContractExpireDate { get; set; }
        public double? ContractPrice { get; set; }
        public int? SatisfactionLevelId { get; set; }
        public virtual EnumData SatisfactionLevel { get; set; }
        public int? StationUsageClassificationId { get; set; }
        public virtual EnumData StationUsageClassification { get; set; }
        public int? StationModelId { get; set; }
        public virtual EnumData StationModel { get; set; }
        public string ManufacturerCompany { get; set; }
        public string SellerCompany { get; set; }
        public double? NeededCostsToMeetRequirements { get; set; }
        public string Description { get; set; }
        public virtual ICollection<AirQualityStationParametersAnalyzer> AirQualityStationParametersAnalyzers { get; set; }
        public virtual ICollection<AirQualityStationMeteorologicalSystem> AirQualityStationMeteorologicalSystems { get; set; }
        public AirQualityMonitoringStation()
        {
            StationAddress = new Address();
            Manager = new Person();
            AirQualityStationParametersAnalyzers = new HashSet<AirQualityStationParametersAnalyzer>();
            AirQualityStationMeteorologicalSystems = new HashSet<AirQualityStationMeteorologicalSystem>();
        }
    }
}
