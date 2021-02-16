using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryEvaluationSelectedAsGreenIndustryInformations : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryEvaluation IndustryEvaluation { get; set; }
        public int IndustryEvaluationId { get; set; }
        public int Year { get; set; }
    }
}
