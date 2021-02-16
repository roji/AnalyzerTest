using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class Wastewater : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        // Wastewater Information
        public string WastewaterEmissionUnitName { get; set; }
        public virtual EnumData WastewaterType { get; set; }
        public int WastewaterTypeId { get; set; }
        public virtual EnumData WastewaterProductionReleaseType { get; set; }
        public int WastewaterProductionReleaseTypeId { get; set; }
        [NotMapped]
        public ICollection<int> WastewaterCombinationClassifications { get; set; }
        public string WastewaterCombinationClassificationIds
        {
            get { return string.Join(",", WastewaterCombinationClassifications); }
            set { if (!string.IsNullOrWhiteSpace(value)) { WastewaterCombinationClassifications = value.Split(',').Select(int.Parse).ToList(); } }
        }
        [NotMapped]
        public virtual ICollection<int> DangerousProperties { get; set; }
        public string DangerousPropertiesIds
        {
            get { return string.Join(",", DangerousProperties); }
            set { if (!string.IsNullOrWhiteSpace(value)) { DangerousProperties = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public bool NeedPurificationSystem { get; set; }
        public string Description { get; set; }
        // Physical Information
        public string ColorDescription { get; set; }
        public string OpacityDescription { get; set; }
        public string TemperatureDescription { get; set; }
        public string SmellDescription { get; set; }
        public string SolidsDescription { get; set; }
        // Biological Properties
        public bool Bacterias { get; set; }
        public string BacteriasDescription { get; set; }
        public bool Coliforms { get; set; }
        public string ColiformsDescription { get; set; }
        public bool ParasitesEgg { get; set; }
        public string ParasitesEggDescription { get; set; }
        public bool Pathogens { get; set; }
        public string PathogensDescription { get; set; }
        // Chemical Properties
        public virtual ICollection<ChemicalPropertiesParameters> ChemicalPropertiesParameters { get; set; }
        //Wastewater Produce Information
        public int HourlyAverageQuantity { get; set; }
        public virtual EnumData HaqMeasurementUnit { get; set; }
        public int HaqMeasurementUnitId { get; set; }
        public int HourlyMaximumQuantity { get; set; }
        public virtual EnumData HmqMeasurementUnit { get; set; }
        public int HmqMeasurementUnitId { get; set; }
        public int DailyAverageQuantity { get; set; }
        public virtual EnumData DaqMeasurementUnit { get; set; }
        public int DaqMeasurementUnitId { get; set; }
        public int DailyMaximumQuantity { get; set; }
        public virtual EnumData DmqMeasurementUnit { get; set; }
        public int DmqMeasurementUnitId { get; set; }
        // Wastewater Purification Information
        public virtual WwHasPurificationSystems WwHasPurificationSystem { get; set; }
        public virtual WwUseMotherPurificationSystems WwUseMotherPurificationSystem { get; set; }
        public virtual WastewaterPurificationSystem WastewaterPurificationSystem { get; set; }
        // Relation To Industry
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public Wastewater()
        {
            DangerousProperties = new List<int>();
            WastewaterCombinationClassifications = new List<int>();
            ChemicalPropertiesParameters = new List<ChemicalPropertiesParameters>();
        }
    }
    public enum WastewaterPurificationSystem : int
    {
        HasntWastewaterPurificationSystem = 0,
        HasWastewaterPurificationSystem = 1,
        UseMotherPurificationSystem = 2
    }
}
