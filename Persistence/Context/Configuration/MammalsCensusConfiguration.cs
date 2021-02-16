using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class MammalsCensusConfiguration : IEntityTypeConfiguration<MammalsCensus>
   {
      public void Configure(EntityTypeBuilder<MammalsCensus> builder)
      {
         builder.HasOne(q => q.QuadrupleArea).WithMany().HasForeignKey(q => q.QuadrupleAreaId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Persons).WithOne(p => p.MammalsCensus).HasForeignKey(k => k.MammalsCensusId);
         builder.HasMany(p => p.Species).WithOne(p => p.MammalsCensus).HasForeignKey(k => k.MammalsCensusId);
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
         builder.HasIndex(q => q.FinalSave);
      }
   }
}
