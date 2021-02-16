using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentCaseAdditionalInfoConfiguration : IEntityTypeConfiguration<IndustryEstablishmentCaseAdditionalInfo>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentCaseAdditionalInfo> builder)
      {
         builder.HasOne(p => p.Industry).WithOne(f => f.EstablishmentCaseAdditionalInfo);
         builder.HasOne(q => q.RoadType).WithMany().HasForeignKey(q => q.RoadTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.IntendedLandUsage).WithMany().HasForeignKey(q => q.IntendedLandUsageId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.NeighborLandUsage).WithMany().HasForeignKey(q => q.NeighborLandUsageId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.QuadrupleArea).WithMany().HasForeignKey(q => q.QuadrupleAreaId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.QuadrupleAreaType).WithMany().HasForeignKey(q => q.QuadrupleAreaTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Distances).WithOne(q => q.IndustryEstablishmentCaseAdditionalInfo).HasForeignKey(q => q.IndustryEstablishmentCaseAdditionalInfoId);
      }
   }
}
