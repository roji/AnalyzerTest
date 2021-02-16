using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteExportImportDescription : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual WasteExportImport WasteExportImport { get; set; }
        public int WasteExportImportId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserComment { get; set; }
        public string SystemComment { get; set; }
        public DateTimeOffset DescriptionDate { get; set; }
        public WasteExportImportDescriptionTypes DescriptionType { get; set; }
    }
    public enum WasteExportImportDescriptionTypes : int
    {
        [Display(Name = "عمومی")] Public = 1,
        [Display(Name = "خصوصی")] Secret = 2
    }
}
