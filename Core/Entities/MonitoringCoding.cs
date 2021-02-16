using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class MonitoringCoding : IAuditableEntity
    {
        public MonitoringCoding()
        {
            IsicCode10 = new List<int>();
            MonitoringParameters = new List<MonitoringParameters>();
        }

        public int Id { get; set; }
        public bool AllIsics { get; set; }
        public int? IsicCode2Id { get; set; }
        public bool AllIsic4s { get; set; }
        public int? IsicCode4Id { get; set; }
        public bool? AllIsic10s { get; set; }
        public int MonitoringTypeId { get; set; }
        public int? WasteClassificationId { get; set; }
        public int? WasteNameId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? PollutionReleaseSourceId { get; set; }
        public int? AcceptedResourceId { get; set; }
        public virtual EstablishmentCode? EstablishmentCode { get; set; }
        public int? PrivateCodingId { get; set; }
        public virtual EnumData IsicCode2 { get; set; }
        public virtual EnumData IsicCode4 { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public virtual EnumData WasteClassification { get; set; }
        public virtual EnumData WasteName { get; set; }
        public virtual EnumData FuelType { get; set; }
        public virtual EnumData PollutionReleaseSource { get; set; }
        public virtual EnumData AcceptedResource { get; set; }
        public virtual Industry PrivateCoding { get; set; }

        [NotMapped] public ICollection<int> IsicCode10 { get; set; }

        public string IsicCode10Ids
        {
            get { return string.Join(",", IsicCode10); }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    IsicCode10 = value.Split(',').Select(int.Parse).ToList();
                }
            }
        }
        public virtual ICollection<MonitoringParameters> MonitoringParameters { get; set; }
    }
    public enum EstablishmentCode : int
    {
        FirstDegree = 0,
        SecondDegree = 1,
    }
}
