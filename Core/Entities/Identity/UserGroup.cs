using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class UserGroup : IAuditableEntity
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public virtual User User { get; set; }
        public virtual Group Group { get; set; }
    }
}
