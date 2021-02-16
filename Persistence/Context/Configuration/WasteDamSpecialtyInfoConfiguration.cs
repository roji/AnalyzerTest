using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteDamSpecialtyInfoConfiguration : IEntityTypeConfiguration<WasteDamSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<WasteDamSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.WasteDamType).WithMany().HasForeignKey(q => q.WasteDamTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.RelatedIndustry).WithMany().HasForeignKey(q => q.RelatedIndustryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.RelatedMine).WithMany().HasForeignKey(q => q.RelatedMineId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithOne(y => y.WasteDamSpecialtyInfo).HasForeignKey<WasteDamSpecialtyInfo>(q => q.IndustryId);
            builder.HasMany(q => q.Problems).WithOne(y => y.WasteDamSpecialtyInfo).HasForeignKey(y => y.WasteDamSpecialtyInfoId);
            builder.HasMany(q => q.WaterQualityMonitoringStations).WithOne(y => y.WasteDamSpecialtyInfo).HasForeignKey(y => y.WasteDamSpecialtyInfoId);
        }
    }
}