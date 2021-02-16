
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WwUseMotherPurificationSystemsConfiguration : IEntityTypeConfiguration<WwUseMotherPurificationSystems>
    {
        public void Configure(EntityTypeBuilder<WwUseMotherPurificationSystems> builder)
        {
            builder.HasOne(p => p.Wastewater).WithOne(f => f.WwUseMotherPurificationSystem).HasForeignKey<WwUseMotherPurificationSystems>(q => q.WastewaterId);
        }
    }
}
