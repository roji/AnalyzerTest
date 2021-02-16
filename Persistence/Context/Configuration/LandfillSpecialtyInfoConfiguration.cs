
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LandfillSpecialtyInfoConfiguration : IEntityTypeConfiguration<LandfillSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<LandfillSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.BurialMethod).WithMany().HasForeignKey(q => q.BurialMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithOne(y => y.LandfillSpecialtyInfo).HasForeignKey<LandfillSpecialtyInfo>(q => q.IndustryId);
            builder.HasMany(q => q.WasteAcceptingIndustries).WithOne(y => y.LandfillSpecialtyInfo).HasForeignKey(y => y.LandfillSpecialtyInfoId);
            builder.HasOne(q => q.BurialInformation).WithOne(w => w.LandfillSpecialtyInfo);
            builder.HasOne(q => q.TemporaryHoldingInformation).WithOne(w => w.LandfillSpecialtyInfo);
        }
    }
}
