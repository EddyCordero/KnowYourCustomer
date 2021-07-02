using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum NationalityType
    {
        [Display(Name = "Nacional")]
        National,

        [Display(Name = "Extranjero")]
        Foreign
    }
}
