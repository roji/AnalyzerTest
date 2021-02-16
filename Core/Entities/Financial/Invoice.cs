using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Invoice : IAuditableEntity, ISoftDeleteEntity, IAccessControl
   {
      public Invoice()
      {
         OrderItems = new HashSet<OrderItem>();
         CreatedDate = DateTime.UtcNow;
         DueDate = DateTime.UtcNow.AddDays(7);
      }
      public int Id { get; set; }
      public DateTimeOffset CreatedDate { get; set; }
      public DateTimeOffset DueDate { get; set; }
      public Int64 TotalPrice { get; set; }
      public Int64 TotalDiscount { get; set; }
      public bool IsPaid { get; set; }
      public virtual User Customer { get; set; }
      public int CustomerId { get; set; }
      public virtual ICollection<OrderItem> OrderItems { get; set; }
      public static Expression<Func<Invoice, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            uai.UserClaims.Intersect(new string[] { "InvoiceFull", "InvoiceView", "god" }).Any() &&
            (
               (uai.UserClaims.Intersect(new string[] { "god", "dlc_invoice_all" }).Any()) ||
               ((q.CustomerId == uai.LoggedInUserId) ||
                  (uai.UserDataClaims.Invoice_province.Contains(q.Customer.ProvinceId)) ||
                  (uai.UserDataClaims.Invoice_state.Contains(q.Customer.StateId))
               ));
      }
      public static Expression<Func<Invoice, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
}
