
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LabMonitoringTypeStartedDateConfiguration : IEntityTypeConfiguration<LabMonitoringTypeStartedDate>
    {
        public void Configure(EntityTypeBuilder<LabMonitoringTypeStartedDate> builder)
        {
            builder.HasOne(q => q.Lab).WithMany(w => w.MonitoringTypeStartedDates).HasForeignKey(f => f.LabId).IsRequired();
            builder.HasOne(p => p.MonitoringType).WithMany().HasForeignKey(f => f.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
