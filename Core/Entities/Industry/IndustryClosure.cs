using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryClosure : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int ClosureReasonId { get; set; }
        public virtual EnumData ClosureReason { get; set; }
        public string Description { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
