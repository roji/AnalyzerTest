
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteDamSpecialtyInfoProblemConfiguration : IEntityTypeConfiguration<WasteDamSpecialtyInfoProblem>
    {
        public void Configure(EntityTypeBuilder<WasteDamSpecialtyInfoProblem> builder)
        {
            builder.HasOne(q => q.WasteDamSpecialtyInfo).WithMany(y => y.Problems).HasForeignKey(q => q.WasteDamSpecialtyInfoId);
        }
    }
}
