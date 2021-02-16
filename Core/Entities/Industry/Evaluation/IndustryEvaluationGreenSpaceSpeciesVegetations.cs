using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryEvaluationGreenSpaceSpeciesVegetations : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryEvaluation IndustryEvaluation { get; set; }
        public int IndustryEvaluationId { get; set; }
        public virtual EnumData SpeciesVegetationType { get; set; }
        public int SpeciesVegetationTypeId { get; set; }
        public int? Quantity { get; set; }
    }
}
