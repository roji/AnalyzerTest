using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using Core.Contracts;

namespace Core.Entities
{
    public class MedicalCenterUnitsAdditionalInfo : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int? Q1 { get; set; }
        public bool? Q2 { get; set; }
        public bool? Q3 { get; set; }
        public bool? Q4 { get; set; }
        public bool? Q5 { get; set; }
        public bool? Q6 { get; set; }
        public bool? Q7 { get; set; }
        public virtual SeperationStatus? Q8 { get; set; }
        public virtual EnumData WasteHoldingMethod { get; set; }
        public int? WasteHoldingMethodId { get; set; }
        public string WhmDescription { get; set; }
        public bool? Q9 { get; set; }
        public bool? Q10 { get; set; }
        public bool? Q11 { get; set; }
        public bool? Q12 { get; set; }
        public bool? Q13 { get; set; }
        public bool? Q14 { get; set; }
        public bool? Q15 { get; set; }
        public bool? Q16 { get; set; }
        public bool? Q17 { get; set; }
        public bool? Q18 { get; set; }
        public bool? Q19 { get; set; }
        public bool? Q20 { get; set; }
        public bool? Q21 { get; set; }
        public bool? Q22 { get; set; }
        public bool? Q23 { get; set; }
        public bool? Q24 { get; set; }
        public bool? Q25 { get; set; }
        public bool? Q26 { get; set; }
        public bool? Q27 { get; set; }
        public bool? Q28 { get; set; }
        public bool? Q29 { get; set; }
        public bool? Q30 { get; set; }
        public bool? Q31 { get; set; }
        public bool? Q32 { get; set; }
        public bool? Q33 { get; set; }
        public bool? Q34 { get; set; }
        public bool? Q35 { get; set; }
        public bool? Q36 { get; set; }
        public bool? Q37 { get; set; }
        public bool? Q38 { get; set; }
        public bool? Q39 { get; set; }
        public bool? Q40 { get; set; }
        public bool? Q41 { get; set; }
        public bool? Q42 { get; set; }
        public bool? Q43 { get; set; }
        public bool? Q44 { get; set; }
        public bool? Q45 { get; set; }
        public bool? Q46 { get; set; }
        public bool? Q47 { get; set; }
        public bool? Q48 { get; set; }
        public bool? Q49 { get; set; }
        public bool? Q50 { get; set; }
        public bool? Q51 { get; set; }
        public bool? Q52 { get; set; }
        public virtual EnumData MunicipalityCompanyReceivedTariff { get; set; }
        public int? MunicipalityCompanyReceivedTariffId { get; set; }
        public string McrtDescription { get; set; }
        public int? Q53 { get; set; }
        public int? Q54 { get; set; }
        public int? Q55 { get; set; }
        public int? Q56 { get; set; }
        public int? Q57 { get; set; }
        public int? Q58 { get; set; }
        public int? Q59 { get; set; }
        public int? Q60 { get; set; }
        public int? Q61 { get; set; }
        public int? Q62 { get; set; }
        public int? Q63 { get; set; }
        public int? Q64 { get; set; }
        public int? Q65 { get; set; }
        public int? Q66 { get; set; }
        public int? Q67 { get; set; }
        public int? Q68 { get; set; }
        public virtual EnumData MedicalWastesReceiver { get; set; }
        public int? MedicalWastesReceiverId { get; set; }
        public string MwrDescription { get; set; }
        public virtual EnumData MedicalNormalWastesDisposalMethod { get; set; }
        public int? MedicalNormalWastesDisposalMethodId { get; set; }
        public string MnwdmDescription { get; set; }
        public virtual EnumData MedicalInfectionWastesDisposalMethod { get; set; }
        public int? MedicalInfectionWastesDisposalMethodId { get; set; }
        public string MiwdmDescription { get; set; }
        public virtual EnumData MedicalChemistryWastesDisposalMethod { get; set; }
        public int? MedicalChemistryWastesDisposalMethodId { get; set; }
        public string McwdmDescription { get; set; }
        public virtual EnumData HealthExpertGrade { get; set; }
        public int? HealthExpertGradeId { get; set; }
        public string HegDescription { get; set; }
        public bool? Q69 { get; set; }
        public bool? Q70 { get; set; }
        public bool? Q71 { get; set; }
        public bool? Q72 { get; set; } // Half time = 0 , Full time = 1
        public int? Q73 { get; set; }
        public int? Q74 { get; set; }
        public int? Q75 { get; set; }
        public string Q76 { get; set; }
        public string Q77 { get; set; }
        public virtual MedicalCenterUnitsInfo MedicalCenterUnitsInfo { get; set; }
        public int MedicalCenterUnitsInfoId { get; set; }
        public enum SeperationStatus : int
        {
            Bad = 1,
            Normal = 2,
            Good = 3
        }
    }
}
