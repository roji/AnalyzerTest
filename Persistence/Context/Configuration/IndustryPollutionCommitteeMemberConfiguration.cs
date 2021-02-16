
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryPollutionCommitteeMemberConfiguration : IEntityTypeConfiguration<IndustryPollutionCommitteeMember>
    {
        public void Configure(EntityTypeBuilder<IndustryPollutionCommitteeMember> builder)
        {
            builder.Property(p => p.FullName).IsRequired().HasMaxLength(300);
            builder.Property(p => p.Rank).HasMaxLength(500);
            builder.HasOne(p => p.IndustryPollution).WithMany(f => f.CommitteeMembers).HasForeignKey(q => q.IndustryPollutionId);
        }
    }
}
