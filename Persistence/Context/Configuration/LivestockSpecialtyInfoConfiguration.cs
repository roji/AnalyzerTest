
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LivestockSpecialtyInfoConfiguration : IEntityTypeConfiguration<LivestockSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<LivestockSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.LivestockClassification).WithMany().HasForeignKey(q => q.LivestockClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithOne(y => y.LivestockSpecialtyInfo).HasForeignKey<LivestockSpecialtyInfo>(q => q.IndustryId);
            builder.HasMany(q => q.LivestockSpecialtyDetails).WithOne(y => y.LivestockSpecialtyInfo).HasForeignKey(y => y.LivestockSpecialtyInfoId);
            builder.HasOne(q => q.WasteInformation).WithOne(w => w.LivestockSpecialtyInfo);
            builder.HasOne(q => q.AdditionalInformation).WithOne(w => w.LivestockSpecialtyInfo);
        }
    }
}
