using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherConfiguration : IEntityTypeConfiguration<Researcher>
   {
      public void Configure(EntityTypeBuilder<Researcher> builder)
      {

         builder.OwnsOne(p => p.Address, co =>
         {
            co.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            co.ToTable("Researcher_Addresses");
         });

         builder.OwnsOne(p => p.Information, co =>
         {
            co.HasOne(p => p.Religion).WithMany().HasForeignKey(f => f.ReligionId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(p => p.Grade).WithMany().HasForeignKey(f => f.GradeId).OnDelete(DeleteBehavior.Restrict);
            co.ToTable("Researcher_Information");
         });

         builder.HasMany(p => p.ForeignLanguages).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.Educations).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.Skills).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.DeputiesCooperationHistories).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.ConferencePapers).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.CompilationBooks).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.Awards).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.CourseWorkshops).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.CommunityMemberships).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.IsiArticles).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
         builder.HasMany(p => p.JournalMagazines).WithOne(p => p.Researcher).HasForeignKey(f => f.ResearcherId);
      }
   }
}
