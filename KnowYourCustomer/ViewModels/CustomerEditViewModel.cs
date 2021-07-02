using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowYourCustomer.ViewModels
{
    public class CustomerEditViewModel
    {
        public int Id { get; set; }
        public PersonType PersonType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public NationalityType NationalityType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
