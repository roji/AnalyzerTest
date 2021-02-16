using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class River : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual EnumData MainBasin { get; set; }
        public int MainBasinId { get; set; }
        public virtual ICollection<RiverSecondaryBasin> SecondaryBasins { get; set; }
        public double? Length { get; set; }
        public double? DebiPerYearAverage { get; set; }
        public string Origin { get; set; }
        public string OriginLatitude { get; set; }
        public string OriginLongitude { get; set; }
        public string FinalSource { get; set; }
        public string FinalSourceLatitude { get; set; }
        public string FinalSourceLongitude { get; set; }
        public virtual ICollection<RiverPassingProvince> PassingProvinces { get; set; }
        public bool IsInBorder { get; set; }
        public bool IsProtected { get; set; }
        public virtual ICollection<RiverUsageTypes> UsageTypes { get; set; }
        public virtual ICollection<RiverProvinceRange> ProvinceRanges { get; set; }
        public string Polyline { get; set; }
        public River()
        {
            PassingProvinces = new HashSet<RiverPassingProvince>();
            SecondaryBasins = new HashSet<RiverSecondaryBasin>();
            UsageTypes = new HashSet<RiverUsageTypes>();
        }
    }
}
