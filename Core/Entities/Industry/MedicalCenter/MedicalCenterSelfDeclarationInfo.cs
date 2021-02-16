using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class MedicalCenterSelfDeclarationInfo : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public bool? HasOncology { get; set; }
        public int? OncologyNwMonthlyProductionQty { get; set; }
        public int? OncologySwMonthlyProductionQty { get; set; }
        public bool? HasSurgery { get; set; }
        public int? SurgeryNwMonthlyProductionQty { get; set; }
        public int? SurgerySwMonthlyProductionQty { get; set; }
        public bool? HasChemotherapy { get; set; }
        public int? ChemotherapyNwMonthlyProductionQty { get; set; }
        public int? ChemotherapySwMonthlyProductionQty { get; set; }
        public bool? HasGeneralPublicHealth { get; set; }
        public int? GphNwMonthlyProductionQty { get; set; }
        public int? GphSwMonthlyProductionQty { get; set; }
        public bool? HasCardiacCare { get; set; }
        public int? CardiacCareNwMonthlyProductionQty { get; set; }
        public int? CardiacCareSwMonthlyProductionQty { get; set; }
        public bool? HasEmergency { get; set; }
        public int? EmergencyNwMonthlyProductionQty { get; set; }
        public int? EmergencySwMonthlyProductionQty { get; set; }
        public bool? HasBoneMarrowTransplantation { get; set; }
        public int? BmtNwMonthlyProductionQty { get; set; }
        public int? BmtSwMonthlyProductionQty { get; set; }
        public bool? HasDialysisSection { get; set; }
        public int? DialysisSectionNwMonthlyProductionQty { get; set; }
        public int? DialysisSectionSwMonthlyProductionQty { get; set; }
        public bool? HasNuclearMedicineDepartment { get; set; }
        public int? NmdNwMonthlyProductionQty { get; set; }
        public int? NmdSwMonthlyProductionQty { get; set; }
        public bool? HasEndoscopicSection { get; set; }
        public int? EndoscopicSectionNwMonthlyProductionQty { get; set; }
        public int? EndoscopicSectionSwMonthlyProductionQty { get; set; }
        public bool? HasRadiotherapy { get; set; }
        public int? RadiotherapyNwMonthlyProductionQty { get; set; }
        public int? RadiotherapySwMonthlyProductionQty { get; set; }
        public bool? HasSurgeryRoom { get; set; }
        public int? SurgeryRoomNwMonthlyProductionQty { get; set; }
        public int? SurgeryRoomSwMonthlyProductionQty { get; set; }
        public bool? HasDentistry { get; set; }
        public int? DentistryNwMonthlyProductionQty { get; set; }
        public int? DentistrySwMonthlyProductionQty { get; set; }
        public bool? HasMri { get; set; }
        public int? MriNwMonthlyProductionQty { get; set; }
        public int? MriSwMonthlyProductionQty { get; set; }
        public bool? HasCtScan { get; set; }
        public int? CtScanNwMonthlyProductionQty { get; set; }
        public int? CtScanSwMonthlyProductionQty { get; set; }
        public bool? HasSonography { get; set; }
        public int? SonographyNwMonthlyProductionQty { get; set; }
        public int? SonographySwMonthlyProductionQty { get; set; }
        public bool? HasRadiology { get; set; }
        public int? RadiologyNwMonthlyProductionQty { get; set; }
        public int? RadiologySwMonthlyProductionQty { get; set; }
        public bool? HasAngiographyAndAngioplasty { get; set; }
        public int? AaaNwMonthlyProductionQty { get; set; }
        public int? AaaSwMonthlyProductionQty { get; set; }
        public bool? HasGeneticsLaboratory { get; set; }
        public int? GeneticsLaboratoryNwMonthlyProductionQty { get; set; }
        public int? GeneticsLaboratorySwMonthlyProductionQty { get; set; }
        public bool? HasPathologyLaboratory { get; set; }
        public int? PathologyLaboratoryNwMonthlyProductionQty { get; set; }
        public int? PathologyLaboratorySwMonthlyProductionQty { get; set; }
        public bool? HasAudiologists { get; set; }
        public int? AudiologistsNwMonthlyProductionQty { get; set; }
        public int? AudiologistsSwMonthlyProductionQty { get; set; }
        public bool? HasPhysiotherapy { get; set; }
        public int? PhysiotherapyNwMonthlyProductionQty { get; set; }
        public int? PhysiotherapySwMonthlyProductionQty { get; set; }
        public bool? HasPharmacy { get; set; }
        public int? PharmacyNwMonthlyProductionQty { get; set; }
        public int? PharmacySwMonthlyProductionQty { get; set; }
        public bool? HasBloodAndOncology { get; set; }
        public int? BaoNwMonthlyProductionQty { get; set; }
        public int? BaoSwMonthlyProductionQty { get; set; }
        public bool? HasCardiovascular { get; set; }
        public int? CardiovascularNwMonthlyProductionQty { get; set; }
        public int? CardiovascularSwMonthlyProductionQty { get; set; }
        public bool? HasNeurology { get; set; }
        public int? NeurologyNwMonthlyProductionQty { get; set; }
        public int? NeurologySwMonthlyProductionQty { get; set; }
        public bool? HasGeneralSurgery { get; set; }
        public int? GeneralSurgeryNwMonthlyProductionQty { get; set; }
        public int? GeneralSurgerySwMonthlyProductionQty { get; set; }
        public bool? HasEarnoseAndThroat { get; set; }
        public int? EarnoseAndThroatNwMonthlyProductionQty { get; set; }
        public int? EarnoseAndThroatSwMonthlyProductionQty { get; set; }
        public bool? HasPainAndAnesthesia { get; set; }
        public int? PainAndAnesthesiaNwMonthlyProductionQty { get; set; }
        public int? PainAndAnesthesiaSwMonthlyProductionQty { get; set; }
        public bool? HasNephrology { get; set; }
        public int? NephrologyNwMonthlyProductionQty { get; set; }
        public int? NephrologySwMonthlyProductionQty { get; set; }
        public bool? HasSkin { get; set; }
        public int? SkinNwMonthlyProductionQty { get; set; }
        public int? SkinSwMonthlyProductionQty { get; set; }
        public bool? HasPsychiatry { get; set; }
        public int? PsychiatryNwMonthlyProductionQty { get; set; }
        public int? PsychiatrySwMonthlyProductionQty { get; set; }
        public bool? HasInfectious { get; set; }
        public int? InfectiousNwMonthlyProductionQty { get; set; }
        public int? InfectiousSwMonthlyProductionQty { get; set; }
        public bool? HasAdministrativeUnits { get; set; }
        public int? AdministrativeUnitsNwMonthlyProductionQty { get; set; }
        public int? AdministrativeUnitsSwMonthlyProductionQty { get; set; }
        public bool? HasMedicalEquipment { get; set; }
        public int? MedicalEquipmentNwMonthlyProductionQty { get; set; }
        public int? MedicalEquipmentSwMonthlyProductionQty { get; set; }
        public bool? HasNutrition { get; set; }
        public int? NutritionNwMonthlyProductionQty { get; set; }
        public int? NutritionSwMonthlyProductionQty { get; set; }
        public bool? HasLaundryRoom { get; set; }
        public int? LaundryRoomNwMonthlyProductionQty { get; set; }
        public int? LaundryRoomSwMonthlyProductionQty { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
