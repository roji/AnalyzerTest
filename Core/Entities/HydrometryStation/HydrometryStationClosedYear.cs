using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class HydrometryStationClosedYear : IAuditableEntity
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public virtual HydrometryStation HydrometryStation { get; set; }
        public int HydrometryStationId { get; set; }
    }
}

