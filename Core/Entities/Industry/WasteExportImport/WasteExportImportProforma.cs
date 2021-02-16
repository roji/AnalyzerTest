using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class WasteExportImportProforma
    {
        public int Id { get; set; }
        public string ProformaNumber { get; set; }
        public int? ProformaDate { get; set; }
        public virtual EnumData HsCode { get; set; }
        public int? HsCodeId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public virtual Upload ProformaFileName { get; set; }
        [StringLength(38)]
        public string ProformaFileNameId { get; set; }
        public virtual WasteExportImport WasteExportImport { get; set; }
        public int WasteExportImportId { get; set; }
    }
}
