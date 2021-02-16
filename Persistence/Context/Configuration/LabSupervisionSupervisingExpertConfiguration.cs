using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class LabSupervisionSupervisingExpertConfiguration : IEntityTypeConfiguration<LabSupervisionSupervisingExpert>
   {
      public void Configure(EntityTypeBuilder<LabSupervisionSupervisingExpert> builder)
      {
         builder.HasOne(q => q.LabSupervision).WithMany(w => w.SupervisingExperts).HasForeignKey(f => f.LabSupervisionId);
         builder.Property(q => q.FullName).HasMaxLength(256).IsRequired();
         builder.Property(q => q.Rank).HasMaxLength(256).IsRequired();
      }
   }
}
