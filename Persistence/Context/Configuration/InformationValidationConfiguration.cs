
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class InformationValidationConfiguration : IEntityTypeConfiguration<InformationValidation>
   {
      public void Configure(EntityTypeBuilder<InformationValidation> builder)
      {
         builder.HasOne(p => p.User).WithMany(q => q.InformationValidations).HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.SetNull);
         builder.HasOne(q => q.Industry).WithMany(q => q.InformationValidations).HasForeignKey(q => q.IndustryId).OnDelete(DeleteBehavior.Cascade);
         builder.HasOne(q => q.Lab).WithMany(q => q.InformationValidations).HasForeignKey(q => q.LabId).OnDelete(DeleteBehavior.Cascade);
         builder.HasOne(q => q.Hunter).WithMany(q => q.InformationValidations).HasForeignKey(q => q.HunterId).OnDelete(DeleteBehavior.Cascade);
      }
   }
}
