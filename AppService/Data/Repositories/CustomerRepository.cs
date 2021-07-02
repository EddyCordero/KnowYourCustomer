using Domain.Entities;

namespace AppService.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(KnowYourCustomerDbContext database) : base(database)
        { }
    }

    public interface ICustomerRepository : IBaseRepository<Customer> { }
}
