using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Signature
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int ProvinceId { get; set; }
        public virtual EnumData Province { get; set; }
        public UserRanks Rank { get; set; }
        public byte[] UserSignature { get; set; }
    }

    public enum UserRanks : int
    {
        [Display(Name = "مدیر کل حفاظت محیط زیست استان")] GeneralManagerOfEnvironmentalProtection = 1
    }
}
