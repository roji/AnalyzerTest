using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class RiverSecondaryBasin : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual River River { get; set; }
        public int RiverId { get; set; }
        public virtual EnumData SecondaryBasin { get; set; }
        public int SecondaryBasinId { get; set; }
    }
}

