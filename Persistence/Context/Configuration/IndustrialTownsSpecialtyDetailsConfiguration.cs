
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustrialTownsSpecialtyDetailsConfiguration : IEntityTypeConfiguration<IndustrialTownsSpecialtyDetails>
    {
        public void Configure(EntityTypeBuilder<IndustrialTownsSpecialtyDetails> builder)
        {
            builder.HasOne(q => q.Industry).WithMany().HasForeignKey(q => q.IndustryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.IndustrialTownsSpecialtyInfo).WithMany(y => y.IndustrialTownsSpecialtyDetails).HasForeignKey(y => y.IndustrialTownsSpecialtyInfoId);
        }
    }
}
