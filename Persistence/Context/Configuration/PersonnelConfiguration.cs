
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class PersonnelConfiguration : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(255);

            builder.HasOne(q => q.Lab).WithMany(w => w.Personnels).HasForeignKey(f => f.LabId).IsRequired();
            builder.HasOne(p => p.Major).WithMany().HasForeignKey(f => f.MajorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Rank).WithMany().HasForeignKey(f => f.RankId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Grade).WithMany().HasForeignKey(f => f.GradeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Experiences).WithOne(p => p.Personnel).HasForeignKey(p => p.PersonnelId);
        }
    }
}
