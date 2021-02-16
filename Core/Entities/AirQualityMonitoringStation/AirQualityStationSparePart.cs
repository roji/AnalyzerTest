using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class AirQualityStationSparePart : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData StationSparePart { get; set; }
        public int StationSparePartId { get; set; }
        public int AirQualityStationParametersAnalyzerId { get; set; }
        public virtual AirQualityStationParametersAnalyzer AirQualityStationParametersAnalyzer { get; set; }
    }
}

