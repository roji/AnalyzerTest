using System;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class LabInspection : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public int Date { get; set; }
      public string Hour { get; set; }
      public bool? IsLocationVerified { get; set; }
      public string LocationVerifiedDescription { get; set; }
      public bool? IsParameterAndMeasurementMethodsVerified { get; set; }
      public string ParameterAndMeasurementMethodsVerifiedDescription { get; set; }
      public bool? IsPersonnelsInformationVerified { get; set; }
      public string PersonnelsInformationVerifiedDescription { get; set; }
      public bool? IsEquipmentInformationVerified { get; set; }
      public string EquipmentInformationVerifiedDescription { get; set; }
      public bool? IsEquipmentSerialNumberVerified { get; set; }
      public string EquipmentSerialNumberVerifiedDescription { get; set; }
      public bool? IsEquipmentModelNameVerified { get; set; }
      public string EquipmentModelNameVerifiedDescription { get; set; }
      public bool? IsDeviceCalibrationLicenseVerified { get; set; }
      public string DeviceCalibrationLicenseVerifiedDescription { get; set; }
      public bool? IsLabAreaVerified { get; set; }
      public string LabAreaVerifiedDescription { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)]
      public string DocumentFileNameId { get; set; }
      public string DocumentDescription { get; set; }
      public bool? IsUnknownSampleDelivered { get; set; }
      public string UnknownSampleDeliveredDescription { get; set; }
      public bool? IsPracticalTestPerformed { get; set; }
      public string PracticalTestPerformedDescription { get; set; }
      public bool? IsComparativeTestMatch { get; set; }
      public string ComparativeTestMatchDescription { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public int LabId { get; set; }
      public virtual Lab Lab { get; set; }
   }
}
