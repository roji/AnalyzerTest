using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentFinancialRelationConfiguration : IEntityTypeConfiguration<IndustryEstablishmentFinancialRelation>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentFinancialRelation> builder)
      {
         builder.HasMany(q => q.Services).WithOne(q => q.IndustryEstablishmentFinancialRelation).HasForeignKey(q => q.IndustryEstablishmentFinancialRelationId);
      }
   }
}
