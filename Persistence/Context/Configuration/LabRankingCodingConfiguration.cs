
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LabRankingCodingConfiguration : IEntityTypeConfiguration<LabRankingCoding>
    {
        public void Configure(EntityTypeBuilder<LabRankingCoding> builder)
        {
            builder.HasOne(p => p.MonitoringType).WithMany().HasForeignKey(f => f.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.OwnershipStatus).WithMany().HasForeignKey(f => f.OwnershipStatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.ExpertPersonnels).WithOne(p => p.LabRankingCoding).HasForeignKey(k => k.LabRankingCodingId);
            builder.HasMany(p => p.Parameters).WithOne(p => p.LabRankingCoding).HasForeignKey(k => k.LabRankingCodingId);
        }
    }
}
