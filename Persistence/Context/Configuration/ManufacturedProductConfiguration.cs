
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ManufacturedProductConfiguration : IEntityTypeConfiguration<ManufacturedProduct>
    {
        public void Configure(EntityTypeBuilder<ManufacturedProduct> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);

            builder.HasOne(q => q.Industry).WithMany(w => w.ManufacturedProducts).HasForeignKey(f => f.IndustryId).IsRequired();
            builder.HasOne(q => q.IsicCode10).WithMany().HasForeignKey(f => f.IsicCode10Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MapProduction).WithMany().HasForeignKey(f => f.MapProductionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DapProduction).WithMany().HasForeignKey(f => f.DapProductionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.YapProduction).WithMany().HasForeignKey(f => f.YapProductionId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
