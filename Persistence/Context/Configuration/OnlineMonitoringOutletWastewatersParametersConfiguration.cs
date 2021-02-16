
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class OnlineMonitoringOutletWastewatersParametersConfiguration : IEntityTypeConfiguration<OnlineMonitoringOutletWastewatersParameters>
    {
        public void Configure(EntityTypeBuilder<OnlineMonitoringOutletWastewatersParameters> builder)
        {
            builder.HasOne(q => q.IndustryOnlineMonitoringParameters).WithMany(y => y.OutletWastewatersParameters).HasForeignKey(q => q.IndustryOnlineMonitoringParametersId);
            builder.HasOne(p => p.OutletWastewaters);
        }
    }
}
