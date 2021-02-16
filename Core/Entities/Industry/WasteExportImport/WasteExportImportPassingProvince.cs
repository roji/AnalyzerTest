namespace Core.Entities
{
    public class WasteExportImportPassingProvince
    {
        public int Id { get; set; }
        public virtual EnumData Province { get; set; }
        public int ProvinceId { get; set; }
        public virtual WasteExportImport WasteExportImport { get; set; }
        public int WasteExportImportId { get; set; }
    }
}
