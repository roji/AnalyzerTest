
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class GreenIndustryDescriptionsConfiguration : IEntityTypeConfiguration<GreenIndustryDescriptions>
    {
        public void Configure(EntityTypeBuilder<GreenIndustryDescriptions> builder)
        {
            builder.HasOne(q => q.GreenIndustry).WithMany(q => q.Descriptions).HasForeignKey(q => q.GreenIndustryId);
        }
    }
}
