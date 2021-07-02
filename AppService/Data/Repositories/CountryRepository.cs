using Domain.Entities;

namespace AppService.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(KnowYourCustomerDbContext database) : base(database)
        { }
    }

    public interface ICountryRepository : IBaseRepository<Country> { }
}

