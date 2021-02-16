using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Core.Entities
{
    public class Message
    {
        public Message()
        {
            MessageReceivers = new HashSet<MessageReceiver>();
        }
        public int Id { get; set; }
        public string body { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        public int SenderId { get; set; }
        public virtual User Sender { get; set; }
        public Priorities Priority { get; set; }
        public MessageTypes Type { get; set; }
        public DateTimeOffset SentDateTime { get; set; }
        public virtual ICollection<MessageReceiver> MessageReceivers { get; set; }
    }
    public enum Priorities : int
    {
        [Display(Name = "زیاد")] High = 1,
        [Display(Name = "متوسط")] Normal = 2,
        [Display(Name = "کم")] Low = 3
    }
    public enum MessageTypes : int
    {
        [Display(Name = "پیام خصوصی")] PM = 1,
        [Display(Name = "اعلامیه")] Announce = 2,
        [Display(Name = "مدیریت")] Supervisor = 3
    }
}
