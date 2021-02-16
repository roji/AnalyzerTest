
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteCodingConfiguration : IEntityTypeConfiguration<WasteCoding>
    {
        public void Configure(EntityTypeBuilder<WasteCoding> builder)
        {
            builder.HasOne(q => q.IsicCode2).WithMany().HasForeignKey(q => q.IsicCode2Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.IsicCode4).WithMany().HasForeignKey(q => q.IsicCode4Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteClassification).WithMany().HasForeignKey(q => q.WasteClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteName).WithMany().HasForeignKey(q => q.WasteNameId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.IsicCode10).WithMany().HasForeignKey(q => q.IsicCode10Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.HsCode).WithMany().HasForeignKey(q => q.HsCodeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.BaselAB).WithMany().HasForeignKey(q => q.BaselABId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.PrivateCoding).WithMany().HasForeignKey(q => q.PrivateCodingId);
            builder.HasMany(q => q.WasteParameters).WithOne(q => q.WasteCoding).HasForeignKey(q => q.WasteCodingId);
        }
    }
}
