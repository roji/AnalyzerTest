using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ChangeLogConfiguration : IEntityTypeConfiguration<ChangeLog>
   {
      public void Configure(EntityTypeBuilder<ChangeLog> builder)
      {
         builder.Property(q => q.Version).IsRequired().HasMaxLength(100);
         builder.Property(p => p.Title).IsRequired().HasMaxLength(300);
         builder.Property(p => p.Description).IsRequired();
      }
   }
}
