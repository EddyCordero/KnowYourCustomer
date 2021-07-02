using Domain.Entities;
using Domain.Enums;
using KnowYourCustomer.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowYourCustomer.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public int Id { get; set; }
        public PersonType PersonType { get; set; }
        public string PersonTypeView => PersonType.GetDisplayName();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public NationalityType NationalityType { get; set; }
        public string NationalityTypeView => NationalityType.GetDisplayName();
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }

        public List<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    }
}
