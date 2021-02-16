using System;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteTransfersAdditionalIndustries : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int WasteTransferId { get; set; }
        public virtual WasteTransfer WasteTransfer { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual WasteTransferIndustryTypes Type { get; set; }
    }
    public enum WasteTransferIndustryTypes : int
    {
        Customs = 0,
        SpecialFreeZones = 1,
        IndustrialEstateCompanies = 2
    }
}
