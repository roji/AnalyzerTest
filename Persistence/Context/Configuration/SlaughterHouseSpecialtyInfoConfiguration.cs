
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class SlaughterHouseSpecialtyInfoConfiguration : IEntityTypeConfiguration<SlaughterHouseSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<SlaughterHouseSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.SlaughterHouseClassification).WithMany().HasForeignKey(q => q.SlaughterHouseClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.LandType).WithMany().HasForeignKey(q => q.LandTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithOne(y => y.SlaughterHouseSpecialtyInfo).HasForeignKey<SlaughterHouseSpecialtyInfo>(q => q.IndustryId);
        }
    }
}
