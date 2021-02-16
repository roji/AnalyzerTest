using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
   {
      public void Configure(EntityTypeBuilder<OrderItem> builder)
      {
         builder.HasOne(q => q.Service).WithMany(q => q.OrderItems).HasForeignKey(q => q.ServiceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Invoice).WithMany(q => q.OrderItems).HasForeignKey(q => q.InvoiceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
