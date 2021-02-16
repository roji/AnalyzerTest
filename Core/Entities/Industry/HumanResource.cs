using System.Collections;
using System.Collections.Generic;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class HumanResource : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int PersonnelTotalNumber { get; set; }
        public bool HasMorningShift { get; set; }
        public int? MorningShiftPersonnelQuantity { get; set; }
        public string MorningShiftFromHour { get; set; }
        public string MorningShiftToHour { get; set; }
        public bool HasEveningShift { get; set; }
        public int? EveningShiftPersonnelQuantity { get; set; }
        public string EveningShiftFromHour { get; set; }
        public string EveningShiftToHour { get; set; }
        public bool HasNightShift { get; set; }
        public int? NightShiftPersonnelQuantity { get; set; }
        public string NightShiftFromHour { get; set; }
        public string NightShiftToHour { get; set; }
        public bool HasRestShift { get; set; }
        public int? RestShiftPersonnelQuantity { get; set; }
        public string RestShiftFromHour { get; set; }
        public string RestShiftToHour { get; set; }
        public string Description { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }

    }
}
