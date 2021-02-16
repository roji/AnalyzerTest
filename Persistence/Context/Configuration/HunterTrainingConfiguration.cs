using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HunterTrainingConfiguration : IEntityTypeConfiguration<HunterTraining>
   {
      public void Configure(EntityTypeBuilder<HunterTraining> builder)
      {
         builder.HasOne(q => q.Hunter).WithOne(q => q.Training).OnDelete(DeleteBehavior.Restrict);
         builder.Property(q => q.LicenseNumber).HasMaxLength(256).IsRequired();
      }
   }
}
