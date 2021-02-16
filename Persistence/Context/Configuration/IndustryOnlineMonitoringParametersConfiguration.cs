
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryOnlineMonitoringParametersConfiguration : IEntityTypeConfiguration<IndustryOnlineMonitoringParameters>
    {
        public void Configure(EntityTypeBuilder<IndustryOnlineMonitoringParameters> builder)
        {
            builder.HasOne(p => p.Parameter).WithMany().HasForeignKey(f => f.ParameterId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.IndustryOnlineMonitoring).WithMany(f => f.OnlineMonitoringParameters).HasForeignKey(q => q.IndustryOnlineMonitoringId);
        }
    }
}
