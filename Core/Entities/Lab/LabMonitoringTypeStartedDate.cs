using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class LabMonitoringTypeStartedDate : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public int MonitoringTypeId { get; set; }
        public int StartedDate { get; set; }
        public int LabId { get; set; }
        public virtual Lab Lab { get; set; }
    }
}
