
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryPollutionTypesConfiguration : IEntityTypeConfiguration<IndustryPollutionTypes>
    {
        public void Configure(EntityTypeBuilder<IndustryPollutionTypes> builder)
        {
            builder.HasOne(p => p.PollutionType).WithMany().HasForeignKey(f => f.PollutionTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.IndustryPollution).WithMany(f => f.PollutionTypes).HasForeignKey(q => q.IndustryPollutionId);
        }
    }
}
