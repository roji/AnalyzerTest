using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class Upload : IAuditableEntity
    { 
      //  public Upload()
      //  {
      //      Id = Guid.NewGuid().ToString();
      //  }
       [Key][StringLength(38)]
       public string Id { get; set; }
       public string OriginalFileName { get; set; }
       public long FileSize { get; set; }
       public uint Crc32 { get; set; } 
       public string AccessName { get; set; }
       public string AccessId { get; set; }
       public string TempFileName { get; set; }  // fsadfshdfhd.dff
    }
}
// /ContainerFolder/RelatedId/FileTypeFolder/TempFileName  => 20
 
 