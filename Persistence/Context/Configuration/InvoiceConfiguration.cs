using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
   {
      public void Configure(EntityTypeBuilder<Invoice> builder)
      {
         builder.Property(q => q.IsPaid).HasDefaultValue(false);
         builder.HasOne(q => q.Customer).WithMany(q => q.Invoices).HasForeignKey(q => q.CustomerId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.OrderItems).WithOne(q => q.Invoice).HasForeignKey(q => q.InvoiceId);
      }
   }
}
