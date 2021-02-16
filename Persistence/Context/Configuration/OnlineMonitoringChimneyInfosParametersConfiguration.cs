
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class OnlineMonitoringChimneyInfosParametersConfiguration : IEntityTypeConfiguration<OnlineMonitoringChimneyInfosParameters>
    {
        public void Configure(EntityTypeBuilder<OnlineMonitoringChimneyInfosParameters> builder)
        {
            builder.HasOne(q => q.IndustryOnlineMonitoringParameters).WithMany(y => y.ChimneyInfosParameters).HasForeignKey(q => q.IndustryOnlineMonitoringParametersId);
            builder.HasOne(p => p.ChimneyInfo);
        }
    }
}
