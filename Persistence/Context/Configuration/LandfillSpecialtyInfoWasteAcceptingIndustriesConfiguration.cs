
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LandfillSpecialtyInfoWasteAcceptingIndustriesConfiguration : IEntityTypeConfiguration<LandfillSpecialtyInfoWasteAcceptingIndustries>
    {
        public void Configure(EntityTypeBuilder<LandfillSpecialtyInfoWasteAcceptingIndustries> builder)
        {
            builder.HasOne(q => q.LandfillSpecialtyInfo).WithMany(q => q.WasteAcceptingIndustries).HasForeignKey(q => q.LandfillSpecialtyInfoId);
            builder.HasOne(q => q.Industry).WithMany().HasForeignKey(q => q.IndustryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
