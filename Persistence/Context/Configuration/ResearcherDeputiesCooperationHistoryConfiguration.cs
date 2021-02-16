using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherDeputiesCooperationHistoryConfiguration : IEntityTypeConfiguration<ResearcherDeputiesCooperationHistory>
   {
      public void Configure(EntityTypeBuilder<ResearcherDeputiesCooperationHistory> builder)
      {
         builder.HasOne(p => p.Office).WithMany().HasForeignKey(f => f.OfficeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Deputy).WithMany().HasForeignKey(f => f.DeputyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Researcher).WithMany(q => q.DeputiesCooperationHistories).HasForeignKey(q => q.ResearcherId);
      }
   }
}
