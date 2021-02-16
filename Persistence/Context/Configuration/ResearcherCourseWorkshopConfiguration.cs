using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherCourseWorkshopConfiguration : IEntityTypeConfiguration<ResearcherCourseWorkshop>
   {
      public void Configure(EntityTypeBuilder<ResearcherCourseWorkshop> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.CourseWorkshops).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.Name).HasMaxLength(256);
         builder.Property(q => q.Organizer).HasMaxLength(256);
         builder.Property(q => q.DegreeTitle).HasMaxLength(256);
      }
   }
}
