using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Core.Entities.AuditableEntity
{
    public static class SoftDeleteProperty
    {
        public static readonly string IsDeleted = nameof(IsDeleted);

        public static void AddSoftDeleteShadowProperties(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model
               .GetEntityTypes()
               .Where(e => typeof(ISoftDeleteEntity).IsAssignableFrom(e.ClrType)))
            {
                modelBuilder.Entity(entityType.ClrType)
                   .Property<bool>(IsDeleted);
            }
        }
        public static void UpdateSoftDeleteStatuses(this ChangeTracker changeTracker)
        {
            foreach (var entry in changeTracker.Entries<ISoftDeleteEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["IsDeleted"] = false;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["IsDeleted"] = true;
                        break;
                }
            }
        }
    }
}
