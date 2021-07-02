using Domain.Enums;

namespace Domain.Entities
{
    public class CustomerAddress : Entity
    {
            public AddressType AddressType { get; set; }
            public int CountryId { get; set; }
            public Country Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string ZipCode { get; set; }
            public bool IsMain { get; set; }
            public string Number { get; set; }
            public string Sector { get; set; }
            public string Notes { get; set; }
            public int CustomerId { get; set; }
            public  Customer Customer { get; set; }
    }
}
