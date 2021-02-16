
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LivestockSpecialtyDetailsConfiguration : IEntityTypeConfiguration<LivestockSpecialtyDetails>
    {
        public void Configure(EntityTypeBuilder<LivestockSpecialtyDetails> builder)
        {
            builder.HasOne(q => q.DomesticatedAnimalsClassification).WithMany().HasForeignKey(q => q.DomesticatedAnimalsClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.LivestockSpecialtyInfo).WithMany(y => y.LivestockSpecialtyDetails).HasForeignKey(q => q.LivestockSpecialtyInfoId);
        }
    }
}
