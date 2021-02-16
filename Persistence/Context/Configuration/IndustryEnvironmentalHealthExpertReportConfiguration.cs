
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryEnvironmentalHealthExpertReportConfiguration : IEntityTypeConfiguration<IndustryEnvironmentalHealthExpertReport>
    {
        public void Configure(EntityTypeBuilder<IndustryEnvironmentalHealthExpertReport> builder)
        {
            builder.HasOne(q => q.Industry).WithMany(w => w.EnvironmentalHealthExpertReports).HasForeignKey(q => q.IndustryId);
            builder.HasOne(p => p.DisinfectionDeviceStatus).WithMany().HasForeignKey(f => f.DisinfectionDeviceStatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ShredderType).WithMany().HasForeignKey(f => f.ShredderTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.UsingOtherIndustryDisinfectionDevices).WithOne(p => p.IndustryEnvironmentalHealthExpertReport).HasForeignKey(k => k.IndustryEnvironmentalHealthExpertReportId);
        }
    }
}
