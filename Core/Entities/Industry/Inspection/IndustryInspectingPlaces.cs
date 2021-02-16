using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryInspectingPlaces : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryInspection IndustryInspection { get; set; }
        public int IndustryInspectionId { get; set; }
        public string Place { get; set; }
    }
}
