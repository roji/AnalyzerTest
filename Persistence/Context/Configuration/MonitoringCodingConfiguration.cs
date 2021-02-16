
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MonitoringCodingConfiguration : IEntityTypeConfiguration<MonitoringCoding>
    {
        public void Configure(EntityTypeBuilder<MonitoringCoding> builder)
        {
            builder.HasOne(q => q.IsicCode2).WithMany().HasForeignKey(q => q.IsicCode2Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.IsicCode4).WithMany().HasForeignKey(q => q.IsicCode4Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteClassification).WithMany().HasForeignKey(q => q.WasteClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteName).WithMany().HasForeignKey(q => q.WasteNameId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MonitoringType).WithMany().HasForeignKey(q => q.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.FuelType).WithMany().HasForeignKey(q => q.FuelTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.PollutionReleaseSource).WithMany().HasForeignKey(q => q.PollutionReleaseSourceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.AcceptedResource).WithMany().HasForeignKey(q => q.AcceptedResourceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.PrivateCoding).WithMany().HasForeignKey(q => q.PrivateCodingId);
            builder.HasMany(q => q.MonitoringParameters).WithOne(q => q.MonitoringCoding).HasForeignKey(q => q.MonitoringCodingId);

        }
    }
}
