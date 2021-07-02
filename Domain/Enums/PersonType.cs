using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum PersonType
    {
        [Display(Name = "Persona Fisica")]
        Fisical = 1,

        [Display(Name = "Persona Juridica")]
        Legal = 2
    }
}
