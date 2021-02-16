using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class MammalsCensusSpecieConfiguration : IEntityTypeConfiguration<MammalsCensusSpecie>
   {
      public void Configure(EntityTypeBuilder<MammalsCensusSpecie> builder)
      {
         builder.HasOne(q => q.MammalsCensus).WithMany(w => w.Species).HasForeignKey(f => f.MammalsCensusId);
         builder.HasOne(q => q.Specie).WithMany().HasForeignKey(q => q.SpecieId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Site).WithMany(w => w.MammalsCensusSpecies).HasForeignKey(q => q.SiteId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
