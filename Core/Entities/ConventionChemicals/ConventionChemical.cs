using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class ConventionChemical : IAuditableEntity
    {
        public ConventionChemical()
        {
            HsCodeMixtures = new HashSet<ConventionChemicalHsCodeMixture>();
        }

        public int Id { get; set; }
        public ConventionTypes Type { get; set; }
        public virtual EnumData Attachment { get; set; }
        public int? AttachmentId { get; set; }
        public virtual EnumData Group { get; set; }
        public int? GroupId { get; set; }
        public string FarsiName { get; set; }
        public string EnglishName { get; set; }
        public string CasNumber { get; set; }
        public virtual EnumData HsCode { get; set; }
        public int? HsCodeId { get; set; }
        public virtual ICollection<ConventionChemicalHsCodeMixture> HsCodeMixtures { get; set; }
    }

    public enum ConventionTypes : int
    {
        [Display(Name = "روتردام")] Rotterdam = 1,
        [Display(Name = "استکهلم")] Stockholm = 2
    }
}
