using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HospitalTesterPersonnelConfiguration : IEntityTypeConfiguration<HospitalTesterPersonnel>
   {
      public void Configure(EntityTypeBuilder<HospitalTesterPersonnel> builder)
      {
         builder.HasOne(q => q.HospitalSamplingResult).WithMany(y => y.Testers).HasForeignKey(q => q.HospitalSamplingResultId);
         builder.HasOne(p => p.Personnel).WithMany().HasForeignKey(f => f.PersonnelId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
