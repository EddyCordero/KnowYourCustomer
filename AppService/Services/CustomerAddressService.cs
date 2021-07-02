using AppService.Data.Repositories;
using AppService.Framework;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AppService.Services
{
    public class CustomerAddressService : BaseService<CustomerAddress, ICustomerAddressRepository>, ICustomerAddressService
    {
        public CustomerAddressService(ICustomerAddressRepository mainRepository) : base(mainRepository)
        { }

        public List<CustomerAddress> GetAllByCustomerId(int customerId)
        {
            var list = _mainRepository.Get(j => j.CustomerId == customerId && j.DeletedAt == null, "Country")
                .ToList();

            return list;
        }

        public List<CustomerAddress> GetAllCustomers()
        {
            var list = _mainRepository.GetAll().ToList();

            return list;
        }

        public CustomerAddress GetById(int id)
        {
            var entity = _mainRepository.GetById(id);

            return entity;
        }

        protected override TaskResult<CustomerAddress> ValidateOnCreate(CustomerAddress entity)
        {
            return new TaskResult<CustomerAddress>();
        }

        protected override TaskResult<CustomerAddress> ValidateOnDelete(CustomerAddress entity)
        {
            return new TaskResult<CustomerAddress>();
        }

        protected override TaskResult<CustomerAddress> ValidateOnUpdate(CustomerAddress entity)
        {
            return new TaskResult<CustomerAddress>();
        }

       
    }

    public interface ICustomerAddressService : IBaseService<CustomerAddress, ICustomerAddressRepository>
    {
        List<CustomerAddress> GetAllCustomers();
        CustomerAddress GetById(int id);

        List<CustomerAddress> GetAllByCustomerId(int customerId);
    }
}
