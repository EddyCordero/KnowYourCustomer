using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum AddressType
    {
        [Display(Name = "Casa")]
        Home = 1,

        [Display(Name = "Oficina")]
        Office = 2,

        [Display(Name = "Local")]
        Local = 3
    }
}
