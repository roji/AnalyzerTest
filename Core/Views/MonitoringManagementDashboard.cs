namespace Core.Entities
{
    public class MonitoringManagementDashboard
    {
        public string Province { get; set; }
        public int TotalIndustries { get; set; }
        public int MonitoringCoveredIndustries { get; set; }
        public int NoNeedToBeCoveredIndustries { get; set; }
        public int AmbientAirMonitoringQuantity { get; set; }
        public int ChimneyMonitoringQuantity { get; set; }
        public int WastewaterMonitoringQuantity { get; set; }
        public int WasteMonitoringQuantity { get; set; }
        public int SoundAndWavesMonitoringQuantity { get; set; }
        public int MotorVehiclesMonitoringQuantity { get; set; }
        public int TotalMonitoringQuantity
        {
            get
            {
                return AmbientAirMonitoringQuantity + ChimneyMonitoringQuantity +
                WasteMonitoringQuantity + WastewaterMonitoringQuantity + SoundAndWavesMonitoringQuantity +
                MotorVehiclesMonitoringQuantity;
            }
        }
        public int AmbientAirVisitedByAdministrationsQuantity { get; set; }
        public int ChimneyVisitedByAdministrationsQuantity { get; set; }
        public int WasteVisitedByAdministrationsQuantity { get; set; }
        public int WastewaterVisitedByAdministrationsQuantity { get; set; }
        public int SoundAndWavesVisitedByAdministrationsQuantity { get; set; }
        public int MotorVehiclesVisitedByAdministrationsQuantity { get; set; }
        public int TotalVisitedIndustriesByAdministrationsQuantity
        {
            get
            {
                return AmbientAirVisitedByAdministrationsQuantity + ChimneyVisitedByAdministrationsQuantity +
                WasteVisitedByAdministrationsQuantity + WastewaterVisitedByAdministrationsQuantity +
                SoundAndWavesVisitedByAdministrationsQuantity + MotorVehiclesVisitedByAdministrationsQuantity;
            }
        }
        public int AmbientAirWarningByAdministrationsQuantity { get; set; }
        public int ChimneyWarningByAdministrationsQuantity { get; set; }
        public int WasteWarningByAdministrationsQuantity { get; set; }
        public int WastewaterWarningByAdministrationsQuantity { get; set; }
        public int SoundAndWavesWarningByAdministrationsQuantity { get; set; }
        public int MotorVehiclesWarningByAdministrationsQuantity { get; set; }
        public int TotalWarningIndustriesByAdministrationsQuantity
        {
            get
            {
                return AmbientAirWarningByAdministrationsQuantity + ChimneyWarningByAdministrationsQuantity +
                WasteWarningByAdministrationsQuantity + WastewaterWarningByAdministrationsQuantity +
                SoundAndWavesWarningByAdministrationsQuantity + MotorVehiclesWarningByAdministrationsQuantity;
            }
        }
        public int AmbientAirPollutionQuantity { get; set; }
        public int ChimneyPollutionQuantity { get; set; }
        public int WastePollutionQuantity { get; set; }
        public int WastewaterPollutionQuantity { get; set; }
        public int MotorVehiclesPollutionQuantity { get; set; }
        public int SoundAndWavesPollutionQuantity { get; set; }
        public int TotalPollutionQuantity
        {
            get
            {
                return AmbientAirPollutionQuantity + ChimneyPollutionQuantity +
                WastePollutionQuantity + WastewaterPollutionQuantity +
                SoundAndWavesPollutionQuantity + MotorVehiclesPollutionQuantity;
            }
        }
        public int AmbientAirDefinitePollutionIndustriesQuantity { get; set; }
        public int ChimneyDefinitePollutionIndustriesQuantity { get; set; }
        public int WasteDefinitePollutionIndustriesQuantity { get; set; }
        public int WastewaterDefinitePollutionIndustriesQuantity { get; set; }
        public int SoundAndWavesDefinitePollutionIndustriesQuantity { get; set; }
        public int MotorVehiclesDefinitePollutionIndustriesQuantity { get; set; }
        public int TotalDefinitePollutionIndustries
        {
            get
            {
                return AmbientAirDefinitePollutionIndustriesQuantity + ChimneyDefinitePollutionIndustriesQuantity +
                WasteDefinitePollutionIndustriesQuantity + WastewaterDefinitePollutionIndustriesQuantity +
                SoundAndWavesDefinitePollutionIndustriesQuantity + MotorVehiclesDefinitePollutionIndustriesQuantity;
            }
        }
        public int AmbientAirPollutionInSpring { get; set; }
        public int ChimneyPollutionInSpring { get; set; }
        public int WastePollutionInSpring { get; set; }
        public int WastewaterPollutionInSpring { get; set; }
        public int SoundAndWavesPollutionInSpring { get; set; }
        public int MotorVehiclesPollutionInSpring { get; set; }
        public int TotalPollutionInSpring
        {
            get
            {
                return AmbientAirPollutionInSpring + ChimneyPollutionInSpring +
                WastePollutionInSpring + SoundAndWavesPollutionInSpring +
                MotorVehiclesPollutionInSpring + WastewaterPollutionInSpring;
            }
        }
        public int AmbientAirPollutionInSummer { get; set; }
        public int ChimneyPollutionInSummer { get; set; }
        public int WastePollutionInSummer { get; set; }
        public int WastewaterPollutionInSummer { get; set; }
        public int SoundAndWavesPollutionInSummer { get; set; }
        public int MotorVehiclesPollutionInSummer { get; set; }
        public int TotalPollutionInSummer
        {
            get
            {
                return AmbientAirPollutionInSummer + ChimneyPollutionInSummer +
                WastePollutionInSummer + SoundAndWavesPollutionInSummer +
                MotorVehiclesPollutionInSummer + WastewaterPollutionInSummer;
            }
        }
        public int AmbientAirPollutionInAutumn { get; set; }
        public int ChimneyPollutionInAutumn { get; set; }
        public int WastePollutionInAutumn { get; set; }
        public int WastewaterPollutionInAutumn { get; set; }
        public int SoundAndWavesPollutionInAutumn { get; set; }
        public int MotorVehiclesPollutionInAutumn { get; set; }
        public int TotalPollutionInAutumn
        {
            get
            {
                return AmbientAirPollutionInAutumn + ChimneyPollutionInAutumn +
                WastePollutionInAutumn + SoundAndWavesPollutionInAutumn +
                MotorVehiclesPollutionInAutumn + WastewaterPollutionInAutumn;
            }
        }
        public int AmbientAirPollutionInWinter { get; set; }
        public int ChimneyPollutionInWinter { get; set; }
        public int WastePollutionInWinter { get; set; }
        public int WastewaterPollutionInWinter { get; set; }
        public int SoundAndWavesPollutionInWinter { get; set; }
        public int MotorVehiclesPollutionInWinter { get; set; }
        public int TotalPollutionInWinter
        {
            get
            {
                return AmbientAirPollutionInWinter + ChimneyPollutionInWinter +
                WastePollutionInWinter + SoundAndWavesPollutionInWinter +
                MotorVehiclesPollutionInWinter + WastewaterPollutionInWinter;
            }
        }
    }
}
