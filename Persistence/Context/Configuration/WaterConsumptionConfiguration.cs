using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WaterConsumptionConfiguration : IEntityTypeConfiguration<WaterConsumption>
   {
      public void Configure(EntityTypeBuilder<WaterConsumption> builder)
      {
         builder.Property(q => q.Year).HasDefaultValue(1380);
         builder.HasOne(q => q.GeneralManagerUser).WithMany().HasForeignKey(q => q.GeneralManagerUserId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.ApprovingOrganizationUser).WithMany().HasForeignKey(q => q.ApprovingOrganizationUserId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Industry).WithMany(f => f.WaterConsumptions).HasForeignKey(q => q.IndustryId);
      }
   }
}
