
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RefinerySendingGasTypeConfiguration : IEntityTypeConfiguration<RefinerySendingGasType>
    {
        public void Configure(EntityTypeBuilder<RefinerySendingGasType> builder)
        {
            builder.HasOne(q => q.RefinerySpecialtyInfo).WithMany(y => y.RefinerySendingGasTypes).HasForeignKey(q => q.RefinerySpecialtyInfoId);
            builder.HasOne(p => p.SendingGasType).WithMany().HasForeignKey(f => f.SendingGasTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
