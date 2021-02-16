using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.Context.Configuration
{
   public class EnumDataConfiguration : IEntityTypeConfiguration<EnumData>
   {
      public void Configure(EntityTypeBuilder<EnumData> builder)
      {
         var converter = new EnumToNumberConverter<SystemTypes, int>();
         builder.Property(p => p.Title).IsRequired();
         builder.Property(p => p.Title).HasMaxLength(255);
         builder.HasIndex(p => p.Title);
         builder.Property(p => p.Data).HasMaxLength(255);
         builder.HasIndex(p => p.Data);
         builder.Property(p => p.Category).HasMaxLength(255);
         builder.Property(p => p.SystemType).HasConversion(converter);
         builder.HasOne(q => q.Parent).WithMany(w => w.Children).HasForeignKey(f => f.ParentId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
