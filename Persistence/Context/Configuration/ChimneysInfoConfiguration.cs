
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ChimneysInfoConfiguration : IEntityTypeConfiguration<ChimneysInfo>
    {
        public void Configure(EntityTypeBuilder<ChimneysInfo> builder)
        {
            builder.HasOne(p => p.ReleasePollutionSource).WithMany().HasForeignKey(f => f.ReleasePollutionSourceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MonitoringInfo).WithMany(y => y.ChimneysInfo).HasForeignKey(q => q.MonitoringInfoId);
        }
    }
}
