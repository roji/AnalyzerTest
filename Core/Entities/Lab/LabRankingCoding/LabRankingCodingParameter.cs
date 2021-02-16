namespace Core.Entities
{
    public class LabRankingCodingParameter
    {
        public int Id { get; set; }
        public virtual EnumData ParamClassification { get; set; }
        public int ParamClassificationId { get; set; }
        public int ParameterId { get; set; }
        public virtual EnumData Parameter { get; set; }
        public double Score { get; set; }
        public bool IsNecessary { get; set; }
        public int LabRankingCodingId { get; set; }
        public virtual LabRankingCoding LabRankingCoding { get; set; }
    }
}
