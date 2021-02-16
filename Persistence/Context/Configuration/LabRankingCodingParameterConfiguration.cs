
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LabRankingCodingParameterConfiguration : IEntityTypeConfiguration<LabRankingCodingParameter>
    {
        public void Configure(EntityTypeBuilder<LabRankingCodingParameter> builder)
        {
            builder.HasOne(p => p.ParamClassification).WithMany().HasForeignKey(f => f.ParamClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Parameter).WithMany().HasForeignKey(f => f.ParameterId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LabRankingCoding).WithMany(q => q.Parameters).HasForeignKey(f => f.LabRankingCodingId);
        }
    }
}
