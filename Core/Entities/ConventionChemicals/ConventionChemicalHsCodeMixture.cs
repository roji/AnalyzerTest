using System;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class ConventionChemicalHsCodeMixture
    {
        public int Id { get; set; }
        public int ConventionChemicalId { get; set; }
        public virtual ConventionChemical ConventionChemical { get; set; }
        public int HsCodeId { get; set; }
        public virtual EnumData HsCode { get; set; }
    }
}
