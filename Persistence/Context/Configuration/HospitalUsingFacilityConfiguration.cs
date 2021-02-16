using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HospitalUsingFacilityConfiguration : IEntityTypeConfiguration<HospitalUsingFacility>
   {
      public void Configure(EntityTypeBuilder<HospitalUsingFacility> builder)
      {
         builder.HasOne(q => q.HospitalSamplingResult).WithMany(y => y.HospitalUsingFacilities).HasForeignKey(q => q.HospitalSamplingResultId);
         builder.HasOne(p => p.Industry).WithMany().HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
