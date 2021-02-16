
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(255);

            builder.HasOne(q => q.Lab).WithMany(w => w.Equipments).HasForeignKey(f => f.LabId).IsRequired();
            builder.HasOne(p => p.CalibrationPeriod).WithMany().HasForeignKey(f => f.CalibrationPeriodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SpecialtySection).WithMany().HasForeignKey(f => f.SpecialtySectionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DeviceType).WithMany().HasForeignKey(f => f.DeviceTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
