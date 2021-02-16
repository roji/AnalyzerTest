
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MineSpecialtyInfoMineralMaterialConfiguration : IEntityTypeConfiguration<MineSpecialtyInfoMineralMaterial>
    {
        public void Configure(EntityTypeBuilder<MineSpecialtyInfoMineralMaterial> builder)
        {
            builder.HasOne(q => q.MineralMaterial).WithMany().HasForeignKey(q => q.MineralMaterialId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MineSpecialtyInfo).WithMany(y => y.MineralMaterials).HasForeignKey(q => q.MineSpecialtyInfoId);
        }
    }
}
