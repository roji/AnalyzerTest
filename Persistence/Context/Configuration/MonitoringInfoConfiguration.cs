
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MonitoringInfoConfiguration : IEntityTypeConfiguration<MonitoringInfo>
    {
        public void Configure(EntityTypeBuilder<MonitoringInfo> builder)
        {
            builder.HasOne(q => q.Industry).WithOne(w => w.MonitoringInfo).HasForeignKey<MonitoringInfo>(f => f.IndustryId);
            builder.HasMany(q => q.ChimneysInfo).WithOne(w => w.MonitoringInfo).HasForeignKey(q => q.MonitoringInfoId);
            builder.HasMany(q => q.OutletWastewaters).WithOne(w => w.MonitoringInfo).HasForeignKey(q => q.MonitoringInfoId);
            builder.HasMany(q => q.NeedMonitoringTypes).WithOne(w => w.MonitoringInfo).HasForeignKey(q => q.MonitoringInfoId);
        }
    }
}
