using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherConferencePaperConfiguration : IEntityTypeConfiguration<ResearcherConferencePaper>
   {
      public void Configure(EntityTypeBuilder<ResearcherConferencePaper> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.ConferencePapers).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.PaperName).HasMaxLength(256);
         builder.Property(q => q.ConferenceName).HasMaxLength(256);
      }
   }
}
