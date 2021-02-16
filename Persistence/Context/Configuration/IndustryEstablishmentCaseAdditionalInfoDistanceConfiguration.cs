using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentCaseAdditionalInfoDistanceConfiguration : IEntityTypeConfiguration<IndustryEstablishmentCaseAdditionalInfoDistance>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentCaseAdditionalInfoDistance> builder)
      {
         builder.HasOne(q => q.DistanceFromCentersAreasEcosystems).WithMany().HasForeignKey(q => q.DistanceFromCentersAreasEcosystemsId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.IndustryEstablishmentCaseAdditionalInfo).WithMany(q => q.Distances).HasForeignKey(q => q.IndustryEstablishmentCaseAdditionalInfoId);
      }
   }
}
