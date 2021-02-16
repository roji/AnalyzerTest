namespace Core.Entities
{
    public class LivestockSpecialtyDetails
    {
        public int Id { get; set; }
        public virtual EnumData DomesticatedAnimalsClassification { get; set; }
        public int DomesticatedAnimalsClassificationId { get; set; }
        public int Capacity { get; set; }
        public int CurrentBalance { get; set; }
        public string Race { get; set; }
        public double WeightAverage { get; set; }
        public int LivestockSpecialtyInfoId { get; set; }
        public virtual LivestockSpecialtyInfo LivestockSpecialtyInfo { get; set; }
    }
}
