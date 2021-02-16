using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class WasteExportImportRepresentative
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public virtual Upload NationalCardPhotoFileName { get; set; }
        [StringLength(38)]
        public string NationalCardPhotoFileNameId { get; set; }
        public virtual WasteExportImport WasteExportImport { get; set; }
        public int WasteExportImportId { get; set; }
    }
}
