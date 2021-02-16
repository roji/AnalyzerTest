using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentRequestConfiguration : IEntityTypeConfiguration<IndustryEstablishmentRequest>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentRequest> builder)
      {
         builder.HasOne(q => q.Industry).WithMany(w => w.EstablishmentRequests).HasForeignKey(f => f.IndustryId)
            .OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Invoice).WithMany().HasForeignKey(f => f.InvoiceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Establishments).WithOne(w => w.Request).HasForeignKey(w => w.RequestId);
         builder.HasIndex(q => q.SamtProvidedId).IsUnique();
         builder.Property(q => q.Type).HasDefaultValue(IndustryEstablishmentRequestTypes.NewEstablishmentLicense);
         builder.HasOne(q => q.Protest).WithOne(q => q.IndustryEstablishmentRequest).HasForeignKey<IndustryEstablishmentRequestProtest>(q => q.IndustryEstablishmentRequestId);
      }
   }
}
