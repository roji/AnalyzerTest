using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class GreenIndustryStrategies : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual GreenIndustry GreenIndustry { get; set; }
        public int GreenIndustryId { get; set; }
        public virtual EnumData Indicator { get; set; }
        public int IndicatorId { get; set; }
        public virtual EnumData Criterion { get; set; }
        public int CriterionId { get; set; }
        public virtual EnumData UnderCriteria { get; set; }
        public int UnderCriteriaId { get; set; }
        public virtual EnumData Strategy { get; set; }
        public int StrategyId { get; set; }
        public int? StartingYear { get; set; }
        public int? OperationYear { get; set; }
        public double? Cost { get; set; }
        public string ExecutionOperationTechnicalDetails { get; set; }
        public string PreviousAnalysisResult { get; set; }
        public string CurrentAnalysisResult { get; set; }
        public virtual Upload DocumentFileName { get; set; }
        [StringLength(38)]
        public string DocumentFileNameId { get; set; }
        public double? ProvinceExpertScore { get; set; }
        public double? OrganizationExpertScore { get; set; }
    }
}
