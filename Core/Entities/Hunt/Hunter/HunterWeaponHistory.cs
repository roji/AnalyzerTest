using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class HunterWeaponHistory : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual EnumData WeaponType { get; set; }
        public int WeaponTypeId { get; set; }
        public virtual EnumData WeaponModel { get; set; }
        public int WeaponModelId { get; set; }
        public virtual EnumData WeaponCountry { get; set; }
        public int? WeaponCountryId { get; set; }
        public virtual EnumData LicenseIssuer { get; set; }
        public int? LicenseIssuerId { get; set; }
        public double? Caliber { get; set; }
        public string WeaponNumber { get; set; }
        public string WeaponTransportingLicenseNumber { get; set; }
        public int? WeaponTransportingLicenseRegisterDate { get; set; }
        public virtual EnumData LicenseRegisterProvince { get; set; }
        public int? LicenseRegisterProvinceId { get; set; }
        public virtual EnumData LicenseRegisterState { get; set; }
        public int? LicenseRegisterStateId { get; set; }
        public virtual EnumData LicenseRegisterCity { get; set; }
        public int? LicenseRegisterCityId { get; set; }
        public int LicenseIsValidFromDate { get; set; }
        public int LicenseIsValidToDate { get; set; }
        public virtual Upload WeaponTransportingLicenseFileName { get; set; }
        [StringLength(38)]
        public string WeaponTransportingLicenseFileNameId { get; set; }
        public int HunterId { get; set; }
        public virtual Hunter Hunter { get; set; }
    }
}
