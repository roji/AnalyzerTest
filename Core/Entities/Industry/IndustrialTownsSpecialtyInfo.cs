using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustrialTownsSpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public IndustrialTownsSpecialtyInfo()
        {
            EstablishmentGrouping = new List<int>();
            IndustrialTownsSpecialtyDetails = new HashSet<IndustrialTownsSpecialtyDetails>();
            IndustrialTownsSpecialtyAssignedIndustries = new HashSet<IndustrialTownsSpecialtyAssignedIndustries>();
        }
        public int Id { get; set; }
        public int Area { get; set; }
        public int IndustryHighestClassificationEstablished { get; set; }
        public virtual Upload EstablishmentZoningFileName { get; set; }
        [StringLength(38)]
        public string EstablishmentZoningFileNameId { get; set; }
        public virtual Upload EstablishedIndustryMapFileName { get; set; }
        [StringLength(38)]
        public string EstablishedIndustryMapFileNameId { get; set; }
        public virtual Upload LicenseFileName { get; set; }
        [StringLength(38)]
        public string LicenseFileNameId { get; set; }
        public virtual Upload CommitmentsFileName { get; set; }
        [StringLength(38)]
        public string CommitmentsFileNameId { get; set; }
        public string DevelopmentPrediction { get; set; }
        public float? FuturePredictionArea { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public float? InfrastructureSpace { get; set; }
        public int? AssignedIndustriesQuantity { get; set; }
        public int? UnassignedIndustriesQuantity { get; set; }
        [NotMapped]
        public ICollection<int> EstablishmentGrouping { get; set; }
        public string EstablishmentGroupingIds
        {
            get { return string.Join(",", EstablishmentGrouping); }
            set { if (!string.IsNullOrWhiteSpace(value)) { EstablishmentGrouping = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual ICollection<IndustrialTownsSpecialtyDetails> IndustrialTownsSpecialtyDetails { get; set; }
        public virtual ICollection<IndustrialTownsSpecialtyAssignedIndustries> IndustrialTownsSpecialtyAssignedIndustries { get; set; }
    }
    public class IndustrialTownsSpecialtyDetails : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public bool HadAcceptedWastewater { get; set; }
        public string RejectionReason { get; set; }
        public int? RejectionDate { get; set; }
        public int? DepartmentLetterNumber { get; set; }
        public int? DepartmentLetterDate { get; set; }
        public int IndustrialTownsSpecialtyInfoId { get; set; }
        public virtual IndustrialTownsSpecialtyInfo IndustrialTownsSpecialtyInfo { get; set; }
    }
    public class IndustrialTownsSpecialtyAssignedIndustries : IAuditableEntity
    {
        public int Id { get; set; }
        public string IndustryName { get; set; }
        public int IndustrialTownsSpecialtyInfoId { get; set; }
        public virtual IndustrialTownsSpecialtyInfo IndustrialTownsSpecialtyInfo { get; set; }
    }
}
