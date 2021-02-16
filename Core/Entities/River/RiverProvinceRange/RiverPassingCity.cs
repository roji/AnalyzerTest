using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class RiverPassingCity : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual RiverProvinceRange RiverProvinceRange { get; set; }
        public int RiverProvinceRangeId { get; set; }
        public virtual EnumData City { get; set; }
        public int CityId { get; set; }
    }
}

