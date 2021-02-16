using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class FishermanToolsHistory : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual EnumData ToolsType { get; set; }
        public int ToolsTypeId { get; set; }
        public virtual EnumData ToolsModel { get; set; }
        public int ToolsModelId { get; set; }
        public virtual EnumData ToolsCountry { get; set; }
        public int? ToolsCountryId { get; set; }
        public string Description { get; set; }
        public int HunterId { get; set; }
        public virtual Hunter Hunter { get; set; }
    }
}