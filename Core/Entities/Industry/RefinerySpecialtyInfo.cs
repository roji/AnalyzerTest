using System;
using System.Collections.Generic;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class RefinerySpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public RefinerySpecialtyInfo()
        {

            RefinerySendingGasTypes = new HashSet<RefinerySendingGasType>();
        }
        public int Id { get; set; }
        public bool? HasOutputFlare { get; set; }
        public virtual EnumData FlareType { get; set; }
        public int? FlareTypeId { get; set; }
        public double? SendingGasToFlareQuantity { get; set; }
        public int? FlareOutputTemperature { get; set; }
        public bool? HasCamera { get; set; }
        public int? HoldingDataTimeCycle { get; set; }
        public string CameraViewLink { get; set; }
        public bool? HasFuelPit { get; set; }
        public int? FuelPitQuantity { get; set; }
        public string FuelPitDescription { get; set; }
        public virtual ICollection<RefinerySendingGasType> RefinerySendingGasTypes { get; set; }
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
    public class RefinerySendingGasType : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData SendingGasType { get; set; }
        public int SendingGasTypeId { get; set; }
        public int RefinerySpecialtyInfoId { get; set; }
        public virtual RefinerySpecialtyInfo RefinerySpecialtyInfo { get; set; }
    }
}
