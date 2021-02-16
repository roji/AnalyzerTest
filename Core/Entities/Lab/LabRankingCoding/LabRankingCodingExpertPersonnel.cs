namespace Core.Entities
{
    public class LabRankingCodingExpertPersonnel
    {
        public int Id { get; set; }
        public int RankId { get; set; }
        public virtual EnumData Rank { get; set; }
        public int? PersonnelQuantity { get; set; }
        public int? PersonnelBackgroundRecord { get; set; }
        public int? PriorityCoefficient { get; set; }
        public int LabRankingCodingId { get; set; }
        public virtual LabRankingCoding LabRankingCoding { get; set; }
    }
}
