using System;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class OrderItem : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual Service Service { get; set; }
      public int ServiceId { get; set; }
      public int Quantity { get; set; }
      public Int64 Discount { get; set; }
      public virtual Invoice Invoice { get; set; }
      public int InvoiceId { get; set; }
   }
}
