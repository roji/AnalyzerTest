using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherSkillConfiguration : IEntityTypeConfiguration<ResearcherSkill>
   {
      public void Configure(EntityTypeBuilder<ResearcherSkill> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.Skills).HasForeignKey(q => q.ResearcherId);
      }
   }
}
