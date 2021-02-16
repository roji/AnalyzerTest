
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustrialTownsSpecialtyInfoConfiguration : IEntityTypeConfiguration<IndustrialTownsSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<IndustrialTownsSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.Industry).WithOne(y => y.IndustrialTownsSpecialtyInfo).HasForeignKey<IndustrialTownsSpecialtyInfo>(q => q.IndustryId);
            builder.HasMany(q => q.IndustrialTownsSpecialtyDetails).WithOne(y => y.IndustrialTownsSpecialtyInfo).HasForeignKey(y => y.IndustrialTownsSpecialtyInfoId);
        }
    }
}
