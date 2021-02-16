using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AqueductWellConfiguration : IEntityTypeConfiguration<AqueductWell>
   {
      public void Configure(EntityTypeBuilder<AqueductWell> builder)
      {
         builder.Property(q => q.Latitude).HasMaxLength(50).IsRequired();
         builder.Property(q => q.Longitude).HasMaxLength(50).IsRequired();
         builder.HasOne(q => q.Aqueduct).WithMany(w => w.Wells).HasForeignKey(w => w.AqueductId);
      }
   }
}
