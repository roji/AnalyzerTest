
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class OutletWastewatersConfiguration : IEntityTypeConfiguration<OutletWastewaters>
    {
        public void Configure(EntityTypeBuilder<OutletWastewaters> builder)
        {
            builder.HasOne(p => p.AcceptedResource).WithMany().HasForeignKey(f => f.AcceptedResourceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Wastewater).WithMany().HasForeignKey(f => f.WastewaterId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.MonitoringInfo).WithMany(y => y.OutletWastewaters).HasForeignKey(q => q.MonitoringInfoId);
        }
    }
}
