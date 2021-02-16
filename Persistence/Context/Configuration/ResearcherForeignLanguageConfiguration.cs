using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherForeignLanguageConfiguration : IEntityTypeConfiguration<ResearcherForeignLanguage>
   {
      public void Configure(EntityTypeBuilder<ResearcherForeignLanguage> builder)
      {
         builder.HasOne(p => p.ForeignLanguage).WithMany().HasForeignKey(f => f.ForeignLanguageId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Researcher).WithMany(q => q.ForeignLanguages).HasForeignKey(q => q.ResearcherId);
      }
   }
}
