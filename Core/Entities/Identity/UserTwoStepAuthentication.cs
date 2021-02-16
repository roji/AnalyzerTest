using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class UserTwoStepAuthentication : IAuditableEntity
    {
        [Key]
        [StringLength(38)]
        public string Id { get; set; }
        public DateTimeOffset ExpireTime { get; set; }
        public string RequestHash { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
