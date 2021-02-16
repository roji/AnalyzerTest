using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class MineSpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public MineSpecialtyInfo()
        {
            MineralMaterials = new HashSet<MineSpecialtyInfoMineralMaterial>();
        }
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public virtual EnumData MineType { get; set; }
        public int MineTypeId { get; set; }
        public virtual EnumData MineralGroup { get; set; }
        public int MineralGroupId { get; set; }
        public virtual ICollection<MineSpecialtyInfoMineralMaterial> MineralMaterials { get; set; }
        public double? RangeArea { get; set; }
        public bool? IsInsideProtectedArea { get; set; }
        public string ProtectedAreaName { get; set; }
        public virtual River River { get; set; }
        public int? RiverId { get; set; }
        public double? DistanceToRiver { get; set; }
        public bool? IsInsideRiverRange { get; set; }
        public string QualityOfWaterCloseToMineDescription { get; set; }
        public double? HarvestingMaterialDepth { get; set; }
        public virtual Upload OperatingLicenseFileName { get; set; }
        [StringLength(38)]
        public string OperatingLicenseFileNameId { get; set; }
        public virtual Upload ExplorationLicenseFileName { get; set; }
        [StringLength(38)]
        public string ExplorationLicenseFileNameId { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }

    public class MineSpecialtyInfoMineralMaterial : IAccessControl
    {
        public int Id { get; set; }
        public virtual EnumData MineralMaterial { get; set; }
        public int MineralMaterialId { get; set; }
        public int MineSpecialtyInfoId { get; set; }
        public virtual MineSpecialtyInfo MineSpecialtyInfo { get; set; }
    }
}
