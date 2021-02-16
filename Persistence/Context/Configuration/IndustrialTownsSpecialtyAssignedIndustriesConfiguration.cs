
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustrialTownsSpecialtyAssignedIndustriesConfiguration : IEntityTypeConfiguration<IndustrialTownsSpecialtyAssignedIndustries>
    {
        public void Configure(EntityTypeBuilder<IndustrialTownsSpecialtyAssignedIndustries> builder)
        {
            builder.HasOne(q => q.IndustrialTownsSpecialtyInfo).WithMany(y => y.IndustrialTownsSpecialtyAssignedIndustries).HasForeignKey(y => y.IndustrialTownsSpecialtyInfoId);
        }
    }
}
