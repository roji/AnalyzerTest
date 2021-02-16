using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentCaseConfiguration : IEntityTypeConfiguration<IndustryEstablishmentCase>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentCase> builder)
      {
         builder.HasOne(p => p.Industry).WithOne(f => f.EstablishmentCase);
      }
   }
}
