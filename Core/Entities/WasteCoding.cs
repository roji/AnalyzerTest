using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteCoding : IAuditableEntity
    {
        public WasteCoding()
        {
            WasteBaselRD = new List<int>();
            WasteBaselY = new List<int>();
            WasteBaselH = new List<int>();
            WasteParameters = new List<WasteParameter>();
            Wastes = new List<Waste>();
        }

        public int Id { get; set; }
        public bool AllIsics { get; set; }
        public int? IsicCode2Id { get; set; }
        public bool AllIsic4s { get; set; }
        public int? IsicCode4Id { get; set; }
        public int WasteClassificationId { get; set; }
        public int WasteNameId { get; set; }
        public int IsicCode10Id { get; set; }
        public int HsCodeId { get; set; }
        public int BaselABId { get; set; }
        public int? PrivateCodingId { get; set; }
        public virtual EnumData IsicCode2 { get; set; }
        public virtual EnumData IsicCode4 { get; set; }
        public virtual EnumData WasteClassification { get; set; }
        public virtual EnumData WasteName { get; set; }
        public virtual EnumData IsicCode10 { get; set; }
        public virtual EnumData HsCode { get; set; }
        public virtual EnumData BaselAB { get; set; }
        public virtual Industry PrivateCoding { get; set; }

        [NotMapped] public ICollection<int> WasteBaselY { get; set; }

        public string WasteBaselYIds
        {
            get => string.Join(",", WasteBaselY);
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) WasteBaselY = value.Split(',').Select(int.Parse).ToList();
            }
        }

        [NotMapped] public ICollection<int> WasteBaselH { get; set; }

        public string WasteBaselHIds
        {
            get => string.Join(",", WasteBaselH);
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) WasteBaselH = value.Split(',').Select(int.Parse).ToList();
            }
        }

        [NotMapped] public ICollection<int> WasteBaselRD { get; set; }

        public string WasteBaselRDIds
        {
            get => string.Join(",", WasteBaselRD);
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) WasteBaselRD = value.Split(',').Select(int.Parse).ToList();
            }
        }

        public virtual ICollection<WasteParameter> WasteParameters { get; set; }
        public virtual ICollection<Waste> Wastes { get; set; }
    }
}
