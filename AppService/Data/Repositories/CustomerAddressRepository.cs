using Domain.Entities;

namespace AppService.Data.Repositories
{
    public class CustomerAddressRepository : BaseRepository<CustomerAddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(KnowYourCustomerDbContext database) : base(database)
        { }
    }

    public interface ICustomerAddressRepository : IBaseRepository<CustomerAddress> { }
}
