using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Core.Entities.AuditableEntity;

public class UserClaim : IAuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    [MaxLength(500)]
    public virtual string ClaimType { get; set; }
    [MaxLength(255)]
    public virtual string ClaimValue { get; set; }
}
