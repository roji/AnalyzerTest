
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryUsingOtherIndustryDisinfectionDeviceConfiguration : IEntityTypeConfiguration<IndustryUsingOtherIndustryDisinfectionDevice>
    {
        public void Configure(EntityTypeBuilder<IndustryUsingOtherIndustryDisinfectionDevice> builder)
        {
            builder.HasOne(q => q.IndustryEnvironmentalHealthExpertReport).WithMany(y => y.UsingOtherIndustryDisinfectionDevices).HasForeignKey(q => q.IndustryEnvironmentalHealthExpertReportId);
            builder.HasOne(p => p.Industry).WithMany().HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
