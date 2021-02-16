
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WastewaterConfiguration : IEntityTypeConfiguration<Wastewater>
    {
        public void Configure(EntityTypeBuilder<Wastewater> builder)
        {
            builder.HasOne(q => q.Industry).WithMany(w => w.Wastewaters).HasForeignKey(f => f.IndustryId).IsRequired();
            builder.HasOne(p => p.WastewaterType).WithMany().HasForeignKey(f => f.WastewaterTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WastewaterProductionReleaseType).WithMany().HasForeignKey(f => f.WastewaterProductionReleaseTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.HaqMeasurementUnit).WithMany().HasForeignKey(f => f.HaqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.HmqMeasurementUnit).WithMany().HasForeignKey(f => f.HmqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DaqMeasurementUnit).WithMany().HasForeignKey(f => f.DaqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DmqMeasurementUnit).WithMany().HasForeignKey(f => f.DmqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(q => q.ChemicalPropertiesParameters).WithOne(w => w.Wastewater);
            builder.HasOne(q => q.WwHasPurificationSystem).WithOne(w => w.Wastewater).HasForeignKey<WwHasPurificationSystems>(q => q.WastewaterId);
            builder.HasOne(q => q.WwUseMotherPurificationSystem).WithOne(w => w.Wastewater).HasForeignKey<WwUseMotherPurificationSystems>(q => q.WastewaterId);
        }
    }
}
