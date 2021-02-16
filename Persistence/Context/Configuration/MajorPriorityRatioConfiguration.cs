
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MajorPriorityRatioConfiguration : IEntityTypeConfiguration<MajorPriorityRatio>
    {
        public void Configure(EntityTypeBuilder<MajorPriorityRatio> builder)
        {
            builder.HasKey(e => new { e.MonitoringTypeId, e.MajorId });
            builder.HasOne(p => p.MonitoringType).WithMany().HasForeignKey(f => f.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Major).WithMany().HasForeignKey(f => f.MajorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(p => p.MonitoringTypeId);
            builder.HasIndex(p => p.MajorId);
        }
    }
}
