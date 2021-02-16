using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AquiferConfiguration : IEntityTypeConfiguration<Aquifer>
   {
      public void Configure(EntityTypeBuilder<Aquifer> builder)
      {
         builder.Property(q => q.Name).HasMaxLength(350).IsRequired();
         builder.HasMany(p => p.Provinces).WithOne(p => p.Aquifer).HasForeignKey(f => f.AquiferId);
         builder.HasOne(q => q.MainBasin).WithMany().HasForeignKey(q => q.MainBasinId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.SecondaryBasin).WithMany().HasForeignKey(q => q.SecondaryBasinId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.StudyArea).WithMany().HasForeignKey(q => q.StudyAreaId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Plains).WithOne(w => w.Aquifer).HasForeignKey(w => w.AquiferId);
         builder.HasMany(q => q.Altitudes).WithOne(w => w.Aquifer).HasForeignKey(w => w.AquiferId);
      }
   }
}
