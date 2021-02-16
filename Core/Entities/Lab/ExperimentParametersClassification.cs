namespace Core.Entities
{
    public class ExperimentParametersClassification
    {
        public int Id { get; set; }
        public int ParamClassificationId { get; set; }
        public virtual EnumData ParamClassification { get; set; }
        public int IndustrialUnitsSamplingResultId { get; set; }
        public virtual IndustrialUnitsSamplingResult IndustrialUnitsSamplingResult { get; set; }
    }
}
