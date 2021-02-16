using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;
namespace Core.Entities
{
    public class Group : IAuditableEntity
    {
        public Group()
        {
            UserGroups = new HashSet<UserGroup>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}