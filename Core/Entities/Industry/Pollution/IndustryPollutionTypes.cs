using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryPollutionTypes
    {
        public int Id { get; set; }
        public virtual IndustryPollution IndustryPollution { get; set; }
        public int IndustryPollutionId { get; set; }
        public virtual EnumData PollutionType { get; set; }
        public int? PollutionTypeId { get; set; }
    }
}
