
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LabRankingCodingExpertPersonnelConfiguration : IEntityTypeConfiguration<LabRankingCodingExpertPersonnel>
    {
        public void Configure(EntityTypeBuilder<LabRankingCodingExpertPersonnel> builder)
        {
            builder.HasOne(p => p.Rank).WithMany().HasForeignKey(f => f.RankId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LabRankingCoding).WithMany(q => q.ExpertPersonnels).HasForeignKey(f => f.LabRankingCodingId);
        }
    }
}
