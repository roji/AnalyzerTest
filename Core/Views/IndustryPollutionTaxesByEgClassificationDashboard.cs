namespace Core.Entities
{
    public class IndustryPollutionTaxesByEgClassificationDashboard
    {
        public string EstablishmentGroupingClassification { get; set; }
        public string SeasonTitle { get; set; }
        public int SeasonId { get; set; }
        public int Total { get; set; }
        public int Year { get; set; }
        public int Air { get; set; }
        public int RisklessMedicalDevices { get; set; }
        public int WastewaterAndMedical { get; set; }
        public int Waste { get; set; }
        public int WaterResource { get; set; }
        public int DustResource { get; set; }
        public int MercuryAndHazardousChemicals { get; set; }
        public int Chimney { get; set; }
        public int SoundAndWave { get; set; }
    }
}
