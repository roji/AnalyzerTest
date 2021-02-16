using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class ParameterAndMeasurementMethod : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public string StandardExperimentMethod { get; set; }
        public int? UsingEquipmentId { get; set; }
        public virtual Equipment UsingEquipment { get; set; }
        public int? IngredientClassificationId { get; set; }
        public virtual EnumData IngredientClassification { get; set; }
        public int? IngredientId { get; set; }
        public virtual EnumData Ingredient { get; set; }
        public int LabId { get; set; }
        public virtual Lab Lab { get; set; }

    }
}
