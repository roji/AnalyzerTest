namespace Core.Entities
{
    public class IndustryManagementDashboard
    {
        public string Province { get; set; }
        public int ActiveIndustries { get; set; }
        public int DeactiveIndustries { get; set; }
        public int TotalIndustries
        {
            get
            {
                return (ActiveIndustries + DeactiveIndustries);
            }
        }
        public int ActiveMines { get; set; }
        public int DeactiveMines { get; set; }
        public int TotalMines
        {
            get
            {
                return (ActiveMines + DeactiveMines);
            }
        }
        public int ActiveMedicalCenters { get; set; }
        public int DeactiveMedicalCenters { get; set; }
        public int TotalMedicalCenters
        {
            get
            {
                return (ActiveMedicalCenters + DeactiveMedicalCenters);
            }
        }
        public int ActiveAgriculturals { get; set; }
        public int DectiveAgriculturals { get; set; }
        public int TotalAgriculturals
        {
            get
            {
                return (ActiveAgriculturals + DectiveAgriculturals);

            }
        }
    }
}
