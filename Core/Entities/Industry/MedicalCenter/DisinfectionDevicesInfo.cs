using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class DisinfectionDevicesInfo : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual EnumData DisinfectionDeviceOwnership { get; set; }
        public int? DisinfectionDeviceOwnershipId { get; set; }
        public string DdoDescription { get; set; }
        public virtual EnumData DeviceInActivityCause { get; set; }
        public int? DeviceInActivityCauseId { get; set; }
        public string DiacDescription { get; set; }
        public virtual EnumData DisinfectionMethod { get; set; }
        public int? DisinfectionMethodId { get; set; }
        public string DmDescription { get; set; }
        public virtual EnumData AlternativeDisinfectionMethod { get; set; }
        public int? AlternativeDisinfectionMethodId { get; set; }
        public string AdmDescription { get; set; }
        public string InstalledWasteDisinfectionDevicesName { get; set; }
        public string InstalledWasteDisinfectionDevicesModel { get; set; }
        public int? WasteDisinfectionDeviceInstallationDate { get; set; }
        public bool? AgentForRepairingDevice { get; set; }
        public int? ActiveDisinfectionDevicesTotalRealCapacity { get; set; }
        public int? DisinfectionDeviceTimeDuration { get; set; }
        public int? WorkingCycleQuantity { get; set; }
        public bool? WasteInfectionProductionDeviceFitsCapacity { get; set; }
        public bool? WorkingGuidePapers { get; set; }
        public int? TrainedOperatorsQuantity { get; set; }
        public bool? ProcessRegistrationFeatures { get; set; }
        public virtual UsingChemicalIndicators? UsingChemicalIndicators { get; set; }
        public bool? UsingBiologicalIndicators { get; set; }
        public bool? DoingCalibrationPerYear { get; set; }
        public int? DeviceFailureRatePerYear { get; set; }
        public int? SleepRateAfterEachFailurePerDay { get; set; }
        public virtual MedicalCenterUnitsInfo MedicalCenterUnitsInfo { get; set; }
        public int MedicalCenterUnitsInfoId { get; set; }
    }
    public enum UsingChemicalIndicators : int
    {
        No = 0,
        Yes = 1,
        NotNeeded = 2
    }
}
