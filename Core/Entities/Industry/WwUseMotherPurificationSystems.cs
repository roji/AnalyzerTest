using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WwUseMotherPurificationSystems : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual Wastewater Wastewater { get; set; }
        public int WastewaterId { get; set; }
        public string MotherPurificationSystemName { get; set; }
        public int DistanceToMotherPurificationSystem { get; set; }
        public string DepositAreaLongitude { get; set; }
        public string DepositAreaLatitude { get; set; }
        public WastewaterTransmissionMethods? WastewaterTransmissionMethod { get; set; }
        public string TransmissionFrequency { get; set; }
        public string TfDescription { get; set; }
        public virtual Upload AnalysisFileName { get; set; }
        [StringLength(38)]
        public string AnalysisFileNameId { get; set; }
        public bool? GeneralAdministrationVote { get; set; }
        public string GavDescription { get; set; }
        public virtual Upload ContractWithRefineryReceiverFileName { get; set; }
        [StringLength(38)]
        public string ContractWithRefineryReceiverFileNameId { get; set; }
    }
    public enum WastewaterTransmissionMethods : int
    {
        PermanentlyConnectionWithPipeOrChannel = 1,
        TransmissionWithTanker = 2
    }
}
