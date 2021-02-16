using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class LicenseInfo 
    {
        public virtual EnumData TypeName { get; set; }
        public int? TypeNameId { get; set; }
        public string Number { get; set; }
        public int? LicenseDate { get; set; }
    }
}
