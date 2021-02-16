using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;
namespace Core.Entities
{
    public class MessageReceiver : IAccessControl
    {
        public Int64 Id { get; set; }
        public int MessageId { get; set; }
        public virtual Message Message { get; set; }
        public int? ReciverId { get; set; }
        public virtual User Reciver { get; set; }
        public virtual MessageStatuses SenderStatus { get; set; }
        public MessageStatuses? ReceiverStatus { get; set; }
        public DateTimeOffset? ViewDateTime { get; set; }

        public static Expression<Func<MessageReceiver, bool>> GetEntityLimitation(IUserAccessInfoService uai)
        {
            return q =>
            uai.UserClaims.Intersect(new string[] { "Message", "god" }).Any() &&
            ((q.ReciverId == uai.LoggedInUserId) || (q.Message.SenderId == uai.LoggedInUserId));
        }
        public static Expression<Func<MessageReceiver, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
    }
    public enum MessageStatuses : int
    {
        [Display(Name = "خوانده نشده")] New = 1,
        [Display(Name = "خوانده شده")] Read = 2,
        [Display(Name = "آرشیو شده")] SavedMsg = 3,
        [Display(Name = "حذف شده")] Deleted = 4,
        [Display(Name = "حذف نهایی شده")] HardDeleted = 5
    }
}
