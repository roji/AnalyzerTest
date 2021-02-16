using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class BirdsCensusPersonConfiguration : IEntityTypeConfiguration<BirdsCensusPerson>
   {
      public void Configure(EntityTypeBuilder<BirdsCensusPerson> builder)
      {
         builder.HasOne(q => q.BirdsCensus).WithMany(w => w.Persons).HasForeignKey(f => f.BirdsCensusId);
         builder.Property(q => q.FullName).HasMaxLength(256).IsRequired();
         builder.Property(q => q.Rank).HasMaxLength(256).IsRequired();
      }
   }
}
