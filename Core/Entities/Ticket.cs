using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Ticket : IAccessControl, IAuditableEntity
   {
      public Ticket()
      {
         Replies = new HashSet<TicketReplies>();
         Priority = Priorities.Normal;
         Status = TicketStatuses.New;
         TicketRegion = TicketRegions.UnDefined;
         TicketDateTime = DateTime.UtcNow;
      }

      public int Id { get; set; }
      public virtual EnumData TicketType { get; set; }
      public int? TicketTypeId { get; set; }
      public TicketStatuses Status { get; set; }
      public TicketRegions TicketRegion { get; set; }
      public Priorities Priority { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? StateId { get; set; }
      public virtual EnumData State { get; set; }
      public int? DeputyId { get; set; }
      public virtual EnumData Deputy { get; set; }
      public int? OfficeId { get; set; }
      public virtual EnumData Office { get; set; }
      public int? OfficeGroupId { get; set; }
      public virtual EnumData OfficeGroup { get; set; }
      public string Subject { get; set; }
      public DateTimeOffset TicketDateTime { get; set; }
      public virtual ICollection<TicketReplies> Replies { get; set; }
      public virtual TicketUser TicketUser { get; set; }

      public static Expression<Func<Ticket, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            uai.UserClaims.Intersect(new string[] { "TicketFull", "TicketView", "god" }).Any() &&
            (
               (uai.UserClaims.Intersect(new string[] { "god", "dlc_ticket_all" }).Any()) ||
               ((q.TicketUser.UserId == uai.LoggedInUserId) ||
                  (uai.UserDataClaims.Ticket_type.Contains(q.TicketTypeId)) ||
                  (uai.UserDataClaims.Ticket_deputy.Contains(q.DeputyId)) ||
                  (uai.UserDataClaims.Ticket_office.Contains(q.OfficeId)) ||
                  (uai.UserDataClaims.Ticket_state.Contains(q.StateId)) ||
                  (uai.UserDataClaims.Ticket_province.Contains(q.ProvinceId))
               ));
      }
      public static Expression<Func<Ticket, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }

   public enum TicketStatuses : int
   {
      [Display(Name = "خوانده نشده")] New = 1, [Display(Name = "در دست بررسی")] Pending = 2, [Display(Name = "پاسخ کاربر")] UserAnswered = 3, [Display(Name = "پاسخ کارشناس")] ExpertAnswered = 4, [Display(Name = "بسته شده")] Closed = 5,
   }

   public enum TicketRegions : int
   {
      [Display(Name = "نامشخص")] UnDefined = 0, [Display(Name = "استان")] Province = 1, [Display(Name = "کشور")] Country = 2
   }
}
