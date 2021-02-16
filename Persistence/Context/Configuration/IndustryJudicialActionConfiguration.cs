using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryJudicialActionConfiguration : IEntityTypeConfiguration<IndustryJudicialAction>
   {
      public void Configure(EntityTypeBuilder<IndustryJudicialAction> builder)
      {
         builder.HasOne(p => p.Verdict).WithMany().HasForeignKey(f => f.VerdictId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.CaseStatus).WithMany().HasForeignKey(f => f.CaseStatusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Contractors).WithOne(p => p.JudicialAction).HasForeignKey(f => f.JudicialActionId);
         builder.HasOne(p => p.Industry).WithMany(f => f.JudicialActions).HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict).IsRequired();
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
         builder.HasIndex(q => q.FinalSave);
      }
   }
}
