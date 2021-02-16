
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HuntInstructionWeekLimitationConfiguration : IEntityTypeConfiguration<HuntInstructionWeekLimitation>
    {
        public void Configure(EntityTypeBuilder<HuntInstructionWeekLimitation> builder)
        {
            builder.HasOne(q => q.HuntInstruction).WithMany(y => y.HuntInstructionWeekLimitations).HasForeignKey(q => q.HuntInstructionId);
            builder.HasOne(p => p.DayInWeek).WithMany().HasForeignKey(f => f.DayInWeekId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
