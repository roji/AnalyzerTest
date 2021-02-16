using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentFinancialRelationServicesConfiguration : IEntityTypeConfiguration<IndustryEstablishmentFinancialRelationServices>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentFinancialRelationServices> builder)
      {
         builder.HasOne(q => q.IndustryEstablishmentFinancialRelation).WithMany(q => q.Services).HasForeignKey(q => q.IndustryEstablishmentFinancialRelationId);
         builder.HasOne(q => q.Service).WithMany(q => q.IndustryEstablishmentFinancialRelations).HasForeignKey(q => q.ServiceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
