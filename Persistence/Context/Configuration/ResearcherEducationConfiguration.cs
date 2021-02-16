using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherEducationConfiguration : IEntityTypeConfiguration<ResearcherEducation>
   {
      public void Configure(EntityTypeBuilder<ResearcherEducation> builder)
      {
         builder.HasOne(p => p.Major).WithMany().HasForeignKey(f => f.MajorId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Grade).WithMany().HasForeignKey(f => f.GradeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Researcher).WithMany(q => q.Educations).HasForeignKey(q => q.ResearcherId);
      }
   }
}
