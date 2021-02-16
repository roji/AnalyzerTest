using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class Role:  IAuditableEntity
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
            RoleClaims = new HashSet<RoleClaim>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    }

}
