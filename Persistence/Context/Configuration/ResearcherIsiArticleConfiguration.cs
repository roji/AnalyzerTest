using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherIsiArticleConfiguration : IEntityTypeConfiguration<ResearcherIsiArticle>
   {
      public void Configure(EntityTypeBuilder<ResearcherIsiArticle> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.IsiArticles).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.Name).HasMaxLength(256);
         builder.Property(q => q.Language).HasMaxLength(256);
         builder.Property(q => q.Acceptor).HasMaxLength(256);
      }
   }
}
