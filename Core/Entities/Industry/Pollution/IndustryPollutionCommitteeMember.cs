using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryPollutionCommitteeMember
    {
        public int Id { get; set; }
        public virtual IndustryPollution IndustryPollution { get; set; }
        public int IndustryPollutionId { get; set; }
        public string FullName { get; set; }
        public string Rank { get; set; }
    }
}
