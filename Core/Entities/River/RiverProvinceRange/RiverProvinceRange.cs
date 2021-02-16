using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class RiverProvinceRange : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual River River { get; set; }
        public int RiverId { get; set; }
        public virtual EnumData Province { get; set; }
        public int ProvinceId { get; set; }
        public double? RiverLengthInProvince { get; set; }
        public double? RiverRankingInProvince { get; set; }
        public double? DebiPerYearAverageInProvince { get; set; }
        public string OriginInProvince { get; set; }
        public string OriginLatitudeInProvince { get; set; }
        public string OriginLongitudeInProvince { get; set; }
        public string FinalSourceInProvince { get; set; }
        public string FinalSourceLatitudeInProvince { get; set; }
        public string FinalSourceLongitudeInProvince { get; set; }
        public bool IsProtectedInProvince { get; set; }
        public virtual ICollection<RiverPassingCity> PassingCities { get; set; }
        public virtual ICollection<RiverUsageTypesInProvince> UsageTypesInProvince { get; set; }
        public double? DeterminedRightOfWaterAmount { get; set; }
        public double? UnboundRightOfWaterAmount { get; set; }
        public RiverProvinceRange()
        {
            PassingCities = new HashSet<RiverPassingCity>();
            UsageTypesInProvince = new HashSet<RiverUsageTypesInProvince>();
        }
    }
}
