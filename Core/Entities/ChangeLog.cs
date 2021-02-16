using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ChangeLog : IAuditableEntity
   {
      public ChangeLog()
      {
         ReleaseDate = DateTime.UtcNow;
      }
      public int Id { get; set; }
      public DateTimeOffset ReleaseDate { get; set; }
      public string Version { get; set; }
      public string Title { get; set; }
      public string Description { get; set; }

      [StringLength(38)]
      public string DocumentFileNameId { get; set; }
      public virtual Upload DocumentFileName { get; set; }
   }
}
