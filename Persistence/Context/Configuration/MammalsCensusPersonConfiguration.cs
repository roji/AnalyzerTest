using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class MammalsCensusPersonConfiguration : IEntityTypeConfiguration<MammalsCensusPerson>
   {
      public void Configure(EntityTypeBuilder<MammalsCensusPerson> builder)
      {
         builder.HasOne(q => q.MammalsCensus).WithMany(w => w.Persons).HasForeignKey(f => f.MammalsCensusId);
         builder.Property(q => q.FullName).HasMaxLength(256).IsRequired();
         builder.Property(q => q.Rank).HasMaxLength(256).IsRequired();
      }
   }
}
