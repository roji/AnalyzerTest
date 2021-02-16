
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteTransferConfiguration : IEntityTypeConfiguration<WasteTransfer>
    {
        public void Configure(EntityTypeBuilder<WasteTransfer> builder)
        {
            builder.HasOne(p => p.Waste).WithMany().HasForeignKey(f => f.WasteId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WasteTransferPeriod).WithMany().HasForeignKey(f => f.WasteTransferPeriodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SenderIndustry).WithMany().HasForeignKey(f => f.SenderIndustryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.RecieverIndustry).WithMany().HasForeignKey(f => f.RecieverIndustryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Lab).WithMany().HasForeignKey(f => f.LabId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(q => q.WastesShipments).WithOne(w => w.WasteTransfer);
            builder.HasMany(q => q.WasteTransfersDescriptions).WithOne(w => w.WasteTransfer);
            builder.Property(q => q.TransportationVehicle).HasMaxLength(500);
        }
    }
}
