using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class MedicalCenterUnitsInfo : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual EnumData MedicalCenterDependencyType { get; set; }
        public int? MedicalCenterDependencyTypeId { get; set; }
        public string McdtDescription { get; set; }
        public virtual EnumData MedicalCenterActivityType { get; set; }
        public int? MedicalCenterActivityTypeId { get; set; }
        public string McatDescription { get; set; }
        public int? ActiveBedsQuantity { get; set; }
        public int? ApprovedBedsQuantity { get; set; }
        [NotMapped]
        public ICollection<int> WasteEstimateWays { get; set; }
        public string WasteEstimateWaysIds
        {
            get { return string.Join(",", WasteEstimateWays); }
            set { if (!string.IsNullOrWhiteSpace(value)) { WasteEstimateWays = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public string WewDescription { get; set; }
        public virtual EnumData DisinfectionDeviceStatus { get; set; }
        public int? DisinfectionDeviceStatusId { get; set; }
        public string DdsDescription { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual DisinfectionDevicesInfo DisinfectionDevicesInfo { get; set; }
        public virtual MedicalCenterUnitsAdditionalInfo MedicalCenterUnitsAdditionalInfo { get; set; }
        public MedicalCenterUnitsInfo()
        {
            DisinfectionDevicesInfo = new DisinfectionDevicesInfo();
            MedicalCenterUnitsAdditionalInfo = new MedicalCenterUnitsAdditionalInfo();
            WasteEstimateWays = new List<int>();
        }
    }
}
