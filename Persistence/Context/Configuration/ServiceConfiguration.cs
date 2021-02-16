using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ServiceConfiguration : IEntityTypeConfiguration<Service>
   {
      public void Configure(EntityTypeBuilder<Service> builder)
      {
         builder.Property(q => q.Title).IsRequired().HasMaxLength(256);
         builder.Property(q => q.Type).HasDefaultValue(ServiceTypes.Public);
         builder.HasOne(q => q.MeasurementUnit).WithMany().HasForeignKey(q => q.MeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.OrderItems).WithOne(q => q.Service).HasForeignKey(q => q.ServiceId);
         builder.HasMany(q => q.IndustryEstablishmentFinancialRelations).WithOne(q => q.Service).HasForeignKey(q => q.ServiceId);
      }
   }
}
