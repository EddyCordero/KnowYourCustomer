using AppService.Data.Repositories;
using AppService.Framework;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppService.Services
{
    public class CountryService : BaseService<Country, ICountryRepository>, ICountryService
    {
        public CountryService(ICountryRepository mainRepository) : base(mainRepository)
        { }

        public List<Country> GetAllCountries()
        {
            var list = _mainRepository.GetAll().ToList();

            return list;
        }

        protected override TaskResult<Country> ValidateOnCreate(Country entity)
        {
            return new TaskResult<Country>();
        }

        protected override TaskResult<Country> ValidateOnDelete(Country entity)
        {
            return new TaskResult<Country>();
        }

        protected override TaskResult<Country> ValidateOnUpdate(Country entity)
        {
            return new TaskResult<Country>();
        }
    }

    public interface ICountryService : IBaseService<Country, ICountryRepository>
    {
        List<Country> GetAllCountries();
    }
}
