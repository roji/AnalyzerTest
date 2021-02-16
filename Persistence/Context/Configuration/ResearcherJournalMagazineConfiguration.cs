using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherJournalMagazineConfiguration : IEntityTypeConfiguration<ResearcherJournalMagazine>
   {
      public void Configure(EntityTypeBuilder<ResearcherJournalMagazine> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.JournalMagazines).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.Name).HasMaxLength(256);
         builder.Property(q => q.Number).HasMaxLength(256);
      }
   }
}
