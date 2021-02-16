using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class Assistance : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Introduction { get; set; }
        public int? AssistanceClassificationId { get; set; }
        public virtual EnumData AssistanceClassification { get; set; }
        [StringLength(38)]
        public string HelpFileNameId { get; set; }
        public virtual Upload HelpFileName { get; set; }
        public string FrequentlyAskedQuestions { get; set; }
        [StringLength(38)]
        public string IdentityCardFileNameId { get; set; }
        public virtual Upload IdentityCardFileName { get; set; }
        public string ContactInformation { get; set; }
        public string SurfaceStatement { get; set; }
        public bool HasIdentityNumber { get; set; }
    }
}