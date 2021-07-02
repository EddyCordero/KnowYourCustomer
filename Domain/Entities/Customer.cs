using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Customer : Entity
    {
        public  PersonType PersonType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public NationalityType NationalityType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
