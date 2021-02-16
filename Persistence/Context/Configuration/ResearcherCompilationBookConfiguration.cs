using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherCompilationBookConfiguration : IEntityTypeConfiguration<ResearcherCompilationBook>
   {
      public void Configure(EntityTypeBuilder<ResearcherCompilationBook> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.CompilationBooks).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.Name).HasMaxLength(256);
         builder.Property(q => q.Publisher).HasMaxLength(256);
      }
   }
}
