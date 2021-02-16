using System.Collections.Generic;

namespace Core.Entities
{
    public class ParamRedundancyByEstablishmentGroupingClassificationDashboard
    {
        public string EstablishmentGroupingClassificationTitle { get; set; }
        public int ParamId { get; set; }
        public string ParamTitle { get; set; }
        public int MonitoringYear { get; set; }
        public int ParameterCount { get; set; }
        public int PollutionTypeId { get; set; }
        public string PollutionType { get; set; }
    }
}
