using System;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteTransfersRelatedProvinces : IAuditableEntity
    {
        public int Id { get; set; }
        public int WasteTransferId { get; set; }
        public virtual WasteTransfer WasteTransfer { get; set; }
        public int ProvinceId { get; set; }
        public virtual EnumData Province { get; set; }
    }
}
