using System.Collections.Generic;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class NormalWasteInformation : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual Waste Waste { get; set; }
        public int WasteId { get; set; }
        public double? DailyAverageProduction { get; set; }
        public int? TemporaryHoldingStorageWithDoorQuantity { get; set; }
        public int? TemporaryHoldingStorageWithoutDoorQuantity { get; set; }
        public bool? TemporaryDepotLocationOrTransportCar { get; set; }
        public virtual EnumData DepotLocationType { get; set; }
        public int? DepotLocationTypeId { get; set; }
        public string DltDescription { get; set; }
        public bool? HoldingWithIndustrialWastes { get; set; }
        public string HwiwDescription { get; set; }
        public bool? DepotHasRoof { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool? PackagingInGoodBags { get; set; }
        public string PigbDescription { get; set; }
        public bool? IsWasteSeparated { get; set; }
        public virtual EnumData NormalWasteTransportFrequency { get; set; }
        public int? NormalWasteTransportFrequencyId { get; set; }
        public string TransportingCompanyName { get; set; }
        public bool? HasContract { get; set; }
        public int? ContractExpirationDate { get; set; }
        public virtual Upload ContractFileName { get; set; }
        [StringLength(38)]
        public string ContractFileNameId { get; set; }
        public string WasteTransportFinalDestination { get; set; }
    }
}
