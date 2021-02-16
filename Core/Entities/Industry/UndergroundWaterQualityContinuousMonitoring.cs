using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class UndergroundWaterQualityContinuousMonitoring : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int? MonitoringDate { get; set; }
        public virtual Lab Lab { get; set; }
        public int LabId { get; set; }
        public bool? IsResultSatisfactory { get; set; }
        public virtual Upload AnalysisFileName { get; set; }
        [StringLength(38)]
        public string AnalysisFileNameId { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public string Description { get; set; }
    }

}
