using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class BirdsCensusSpecieConfiguration : IEntityTypeConfiguration<BirdsCensusSpecie>
   {
      public void Configure(EntityTypeBuilder<BirdsCensusSpecie> builder)
      {
         builder.HasOne(q => q.BirdsCensus).WithMany(w => w.Species).HasForeignKey(f => f.BirdsCensusId);
         builder.HasOne(q => q.Specie).WithMany().HasForeignKey(q => q.SpecieId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Genus).WithMany().HasForeignKey(q => q.GenusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Site).WithMany(w => w.BirdsCensusSpecies).HasForeignKey(q => q.SiteId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
