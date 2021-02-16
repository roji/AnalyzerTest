using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ResearcherCommunityMembershipConfiguration : IEntityTypeConfiguration<ResearcherCommunityMembership>
   {
      public void Configure(EntityTypeBuilder<ResearcherCommunityMembership> builder)
      {
         builder.HasOne(q => q.Researcher).WithMany(q => q.CommunityMemberships).HasForeignKey(q => q.ResearcherId);
         builder.Property(q => q.Name).HasMaxLength(256);
         builder.Property(q => q.MembershipType).HasMaxLength(256);
      }
   }
}
