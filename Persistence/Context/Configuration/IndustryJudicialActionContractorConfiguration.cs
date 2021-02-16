using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryJudicialActionContractorConfiguration : IEntityTypeConfiguration<IndustryJudicialActionContractor>
   {
      public void Configure(EntityTypeBuilder<IndustryJudicialActionContractor> builder)
      {
         builder.Property(p => p.FullName).IsRequired().HasMaxLength(300);
         builder.HasOne(p => p.JudicialAction).WithMany(f => f.Contractors).HasForeignKey(q => q.JudicialActionId);
      }
   }
}
