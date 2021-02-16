using System;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteTransfersDescriptions : IAuditableEntity
    {
        public WasteTransfersDescriptions()
        {
            DescriptionDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public virtual WasteTransfer WasteTransfer { get; set; }
        public int WasteTransferId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserComment { get; set; }
        public string SystemComment { get; set; }
        public DateTimeOffset DescriptionDate { get; set; }
        public WasteTransferDescriptionTypes DescriptionType { get; set; }
    }
    public enum WasteTransferDescriptionTypes: int
    {
        Public = 1,
        Secret = 2
    }
}
