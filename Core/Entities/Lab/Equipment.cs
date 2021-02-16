using System.Collections;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class Equipment : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialCode { get; set; }
        public string DeviceModel { get; set; }
        public string FaultyCause { get; set; }
        public string FaultyCauseDescription { get; set; }
        public string AttachmentsDescription { get; set; }
        public int? LastCalibrationDate { get; set; }
        public bool HasAttachments { get; set; }
        public bool IsDeviceHealthy { get; set; }
        public virtual Upload EquipmentPhotoFileName { get; set; }
        [StringLength(38)]
        public string EquipmentPhotoFileNameId { get; set; }
        public virtual Upload CalibrationLicensePhotoFileName { get; set; }
        [StringLength(38)]
        public string CalibrationLicensePhotoFileNameId { get; set; }
        public int? SpecialtySectionId { get; set; }
        public virtual EnumData SpecialtySection { get; set; }
        public int? DeviceTypeId { get; set; }
        public virtual EnumData DeviceType { get; set; }
        public int? CalibrationPeriodId { get; set; }
        public virtual EnumData CalibrationPeriod { get; set; }
        public int LabId { get; set; }
        public virtual Lab Lab { get; set; }

    }
}
