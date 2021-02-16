using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentTariffCodingConfiguration : IEntityTypeConfiguration<IndustryEstablishmentTariffCoding>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentTariffCoding> builder)
      {
         builder.HasOne(p => p.ApplicantStatus).WithMany().HasForeignKey(f => f.ApplicantStatusId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
