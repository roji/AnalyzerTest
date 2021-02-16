using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MineSpecialtyInfoConfiguration : IEntityTypeConfiguration<MineSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<MineSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.MineType).WithMany().HasForeignKey(q => q.MineTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MineralGroup).WithMany().HasForeignKey(q => q.MineralGroupId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.River).WithMany().HasForeignKey(q => q.RiverId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithOne(y => y.MineSpecialtyInfo).HasForeignKey<MineSpecialtyInfo>(q => q.IndustryId);
            builder.HasMany(q => q.MineralMaterials).WithOne(y => y.MineSpecialtyInfo).HasForeignKey(y => y.MineSpecialtyInfoId);
        }
    }
}