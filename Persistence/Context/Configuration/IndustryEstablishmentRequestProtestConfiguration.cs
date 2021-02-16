using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentRequestProtestConfiguration : IEntityTypeConfiguration<IndustryEstablishmentRequestProtest>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentRequestProtest> builder)
      {
         builder.HasOne(q => q.IndustryEstablishmentRequest);
      }
   }
}
