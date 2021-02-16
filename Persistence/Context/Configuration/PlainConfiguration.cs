using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class PlainConfiguration : IEntityTypeConfiguration<Plain>
   {
      public void Configure(EntityTypeBuilder<Plain> builder)
      {
         builder.Property(q => q.Name).HasMaxLength(350).IsRequired();
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.PlainType).WithMany().HasForeignKey(q => q.PlainTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Aquifer).WithMany(w => w.Plains).HasForeignKey(q => q.AquiferId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Aqueducts).WithOne(w => w.Plain).HasForeignKey(w => w.PlainId);
         builder.HasMany(q => q.Pits).WithOne(w => w.Plain).HasForeignKey(w => w.PlainId);
         builder.HasMany(q => q.Fountains).WithOne(w => w.Plain).HasForeignKey(w => w.PlainId);
      }
   }
}
