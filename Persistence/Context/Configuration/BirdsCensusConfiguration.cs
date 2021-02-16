using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class BirdsCensusConfiguration : IEntityTypeConfiguration<BirdsCensus>
   {
      public void Configure(EntityTypeBuilder<BirdsCensus> builder)
      {
         builder.HasOne(q => q.QuadrupleArea).WithMany().HasForeignKey(q => q.QuadrupleAreaId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Persons).WithOne(p => p.BirdsCensus).HasForeignKey(k => k.BirdsCensusId);
         builder.HasMany(p => p.Species).WithOne(p => p.BirdsCensus).HasForeignKey(k => k.BirdsCensusId);
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
         builder.HasIndex(q => q.FinalSave);
      }
   }
}
