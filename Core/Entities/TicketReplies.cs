using System;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
   public class TicketReplies : IAccessControl
   {
      public TicketReplies()
      {
         Rating = Ratings.UnDefined;
         ReplyDateTime = DateTime.UtcNow;
      }
      public int Id { get; set; }
      public Ratings Rating { get; set; }
      public virtual User User { get; set; }
      public int? UserId { get; set; }
      public bool IsExpert { get; set; }
      public string Content { get; set; }
      public DateTimeOffset ReplyDateTime { get; set; }

      [StringLength(38)]
      public string TicketFileNameId { get; set; }
      public virtual Upload TicketFileName { get; set; }
      public virtual Ticket Ticket { get; set; }
      public int TicketId { get; set; }
   }
   public enum Ratings : int
   {
      [Display(Name = "نامشخص")] UnDefined = 0, [Display(Name = "خیلی کم")] VeryLow = 1, [Display(Name = "کم")] Low = 2, [Display(Name = "متوسط")] Medium = 3, [Display(Name = "زیاد")] High = 4, [Display(Name = "خیلی زیاد")] VeryHigh = 5
   }
}
