using AppService.Data.Repositories;
using AppService.Framework;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppService.Services
{
    public class CustomerService : BaseService<Customer, ICustomerRepository>, ICustomerService
    {
        public CustomerService(ICustomerRepository mainRepository) : base(mainRepository)
        { }

        public List<Customer> GetAllCustomers()
        {
            var list = _mainRepository.GetAll().ToList();

            return list;
        }

        public Customer GetById(int id)
        {
            var entity = _mainRepository.GetById(id);

            return entity;
        }

        protected override TaskResult<Customer> ValidateOnCreate(Customer entity)
        {
            return new TaskResult<Customer>();
        }

        protected override TaskResult<Customer> ValidateOnDelete(Customer entity)
        {
            return new TaskResult<Customer>();
        }

        protected override TaskResult<Customer> ValidateOnUpdate(Customer entity)
        {
            return new TaskResult<Customer>();
        }
    }

    public interface ICustomerService : IBaseService<Customer, ICustomerRepository>
    {
        List<Customer> GetAllCustomers();
        Customer GetById(int id);
    }
}
