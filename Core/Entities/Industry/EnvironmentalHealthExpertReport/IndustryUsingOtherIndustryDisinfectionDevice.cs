using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryUsingOtherIndustryDisinfectionDevice : IAuditableEntity
    {
        public int Id { get; set; }
        public int IndustryEnvironmentalHealthExpertReportId { get; set; }
        public virtual IndustryEnvironmentalHealthExpertReport IndustryEnvironmentalHealthExpertReport { get; set; }
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
