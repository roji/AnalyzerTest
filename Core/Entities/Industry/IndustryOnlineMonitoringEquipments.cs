using System.Collections;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;
using Core.Contracts;

namespace Core.Entities
{
    public class IndustryOnlineMonitoringEquipments : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual IndustryOnlineMonitoring IndustryOnlineMonitoring { get; set; }
        public int IndustryOnlineMonitoringId { get; set; }
        public virtual ChimneysInfo ChimneysInfo { get; set; }
        public int? ChimneysInfoId { get; set; }
        public virtual OutletWastewaters OutletWastewater { get; set; }
        public int? OutletWastewaterId { get; set; }
        public string MonitoringDeviceSetupLocation { get; set; }
        public string DeviceModel { get; set; }
        public int? DeviceSetupYear { get; set; }
        public string DeviceSellerCompanyName { get; set; }
        public virtual SellerSupportQualities? SellerSupportQuality { get; set; }
        public string SsqDescription { get; set; }
        public virtual DeviceFunctioningSatisfactionStatuses? DeviceFunctioningSatisfaction { get; set; }
        public string DfsDescription { get; set; }
        public virtual SamplingSystemTypes? SamplingSystem { get; set; }
        public string OnlineMonitoringInformationConnectionLink { get; set; }
    }
    public enum SellerSupportQualities : int
    {
        Good = 1,
        Bad = 2
    }
    public enum DeviceFunctioningSatisfactionStatuses : int
    {
        Good = 1,
        Bad = 2
    }
    public enum SamplingSystemTypes : int
    {
        Extract = 1,
        InPlace = 2
    }
}
