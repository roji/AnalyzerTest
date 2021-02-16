
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class FishermanToolsHistoryConfiguration : IEntityTypeConfiguration<FishermanToolsHistory>
    {
        public void Configure(EntityTypeBuilder<FishermanToolsHistory> builder)
        {
            builder.HasOne(p => p.ToolsType).WithMany().HasForeignKey(f => f.ToolsTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ToolsModel).WithMany().HasForeignKey(f => f.ToolsModelId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ToolsCountry).WithMany().HasForeignKey(f => f.ToolsCountryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Hunter).WithMany(q => q.ToolsHistories).HasForeignKey(f => f.HunterId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
