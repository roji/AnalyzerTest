using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class LabConsumingMaterial : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual EnumData ConsumableMaterialStandardClassification { get; set; }
        public int ConsumableMaterialStandardClassificationId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public virtual EnumData MeasurementUnit { get; set; }
        public int MeasurementUnitId { get; set; }
        public string Manufacturer { get; set; }
        public int? ExpirationDate { get; set; }
        public string Description { get; set; }
        public int LabId { get; set; }
        public virtual Lab Lab { get; set; }
    }
}
