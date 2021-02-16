using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherAwardConfiguration : IEntityTypeConfiguration<ResearcherAward>
   {
      public void Configure(EntityTypeBuilder<ResearcherAward> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.Awards).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.Name).HasMaxLength(256);
         builder.Property(q => q.Presenter).HasMaxLength(256);
      }
   }
}
