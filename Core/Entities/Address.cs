using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class Address : Contact
    {
        public virtual EnumData Province { get; set; }
        public virtual EnumData State { get; set; }
        public virtual EnumData City { get; set; }
        public int? ProvinceId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string IndustrialTown { get; set; }
        public string AddressDetails { get; set; }
        public bool? IsInTownEnv { get; set; }
        public int? DistanceToCity { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Elevation { get; set; }
        public string ZipCode { get; set; }
    }
}
