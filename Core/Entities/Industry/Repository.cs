using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class Repository : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public double Area { get; set; }
        public double? RoofArea { get; set; }
        public double? RooflessArea { get; set; }
        [NotMapped]
        public ICollection<int> MaintainableMaterialClassifications { get; set; }
        public string MaintainableMaterialClassificationIds
        {
            get { return string.Join(",", MaintainableMaterialClassifications); }
            set { if (!string.IsNullOrWhiteSpace(value)) { MaintainableMaterialClassifications = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public bool StandardEquipment { get; set; }
        public bool FireAlarm { get; set; }
        public bool FireFight { get; set; }
        public bool ImpermeableRoofless { get; set; }
        public bool ImpermeableRoof { get; set; }
        public int? RooflessStorageSize { get; set; }
        public int? RlessUnitMeasurementId { get; set; }
        public virtual EnumData RlessUnitMeasurement { get; set; }
        public int? RoofStorageSize { get; set; }
        public int? RssUnitMeasurementId { get; set; }
        public virtual EnumData RssUnitMeasurement { get; set; }
        public string Description { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public Repository()
        {
            MaintainableMaterialClassifications = new List<int>();
        }
    }
}
