using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class LandfillSpecialtyInfoWasteAcceptingIndustries
    {
        public int Id { get; set; }
        public int LandfillSpecialtyInfoId { get; set; }
        public virtual LandfillSpecialtyInfo LandfillSpecialtyInfo { get; set; }
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public double? DailyAverageQuantity { get; set; }
    }
}
