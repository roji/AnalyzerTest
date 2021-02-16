using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryInspectors : IAuditableEntity
    {
        public Int64 Id { get; set; }
        public virtual IndustryInspection IndustryInspection { get; set; }
        public int IndustryInspectionId { get; set; }
        public string FullName { get; set; }
        public string Rank { get; set; }
        public virtual InspectorTypes InspectorType { get; set; }
    }
    public enum InspectorTypes : int
    {
        Inspector = 1,
        PresentManager = 2
    }
}
