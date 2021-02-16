using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class LabInspectionConfiguration : IEntityTypeConfiguration<LabInspection>
   {
      public void Configure(EntityTypeBuilder<LabInspection> builder)
      {
         builder.HasOne(q => q.Lab).WithMany(w => w.Inspections).HasForeignKey(f => f.LabId);
         builder.HasIndex(q => q.FinalSave);
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
      }
   }
}
