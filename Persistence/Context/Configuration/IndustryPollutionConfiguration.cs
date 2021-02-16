
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryPollutionConfiguration : IEntityTypeConfiguration<IndustryPollution>
    {
        public void Configure(EntityTypeBuilder<IndustryPollution> builder)
        {
            builder.HasOne(p => p.Season).WithMany().HasForeignKey(f => f.SeasonId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.PollutionReasons).WithOne(p => p.IndustryPollution).HasForeignKey(f => f.IndustryPollutionId);
            builder.HasOne(p => p.Industry).WithMany(f => f.IndustryPollutions).HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict).IsRequired();
            builder.HasMany(q => q.CommitteeMembers).WithOne(q => q.IndustryPollution).HasForeignKey(q => q.IndustryPollutionId);
        }
    }
}
