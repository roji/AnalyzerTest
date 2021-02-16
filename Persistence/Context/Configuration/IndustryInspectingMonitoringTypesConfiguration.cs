
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryInspectingMonitoringTypesConfiguration : IEntityTypeConfiguration<IndustryInspectingMonitoringTypes>
    {
        public void Configure(EntityTypeBuilder<IndustryInspectingMonitoringTypes> builder)
        {
            builder.HasOne(p => p.MonitoringType).WithMany().HasForeignKey(f => f.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MonitoringTypeQualityStatus).WithMany().HasForeignKey(f => f.MonitoringTypeQualityStatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.IndustryInspection).WithMany(f => f.InspectingMonitoringTypes).HasForeignKey(q => q.IndustryInspectionId);
        }
    }
}
