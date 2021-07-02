using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowYourCustomer.ViewModels
{
    public class CustomerAddViewModel
    {
        public PersonType PersonType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public NationalityType NationalityType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }

        public List<Country> Countries { get; set; } = new List<Country>();
        
       public IEnumerable<SelectListItem> PersonTypes { get; set; }
        public IEnumerable<SelectListItem> NationalityTypes { get; set; }
    }
}
