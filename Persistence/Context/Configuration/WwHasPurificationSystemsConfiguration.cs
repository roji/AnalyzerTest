
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WwHasPurificationSystemsConfiguration : IEntityTypeConfiguration<WwHasPurificationSystems>
    {
        public void Configure(EntityTypeBuilder<WwHasPurificationSystems> builder)
        {
            builder.HasOne(p => p.Wastewater).WithOne(f => f.WwHasPurificationSystem).HasForeignKey<WwHasPurificationSystems>(q => q.WastewaterId);
            builder.HasOne(p => p.SuvMeasurementUnit).WithMany().HasForeignKey(q => q.SuvMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DrsoqMeasurementUnit).WithMany().HasForeignKey(q => q.DrsoqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MrsoqMeasurementUnit).WithMany().HasForeignKey(q => q.MrsoqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.YrsoqMeasurementUnit).WithMany().HasForeignKey(q => q.YrsoqMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SludgeCollectionMeasurementUnit).WithMany().HasForeignKey(q => q.SludgeCollectionMeasurementUnitId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
