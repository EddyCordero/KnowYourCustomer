using AppService.Services;
using Domain.Entities;
using Domain.Enums;
using KnowYourCustomer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowYourCustomer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly ICustomerService _customerService;
        private readonly ICustomerAddressService _customerAddressService;

        public CustomerController(ICustomerService customerService, ICountryService countryService,
            ICustomerAddressService customerAddressService)
        {
            _countryService = countryService;
            _customerService = customerService;
            _customerAddressService = customerAddressService;
        }


        public ActionResult Index()
        {
            var customers = _customerService.GetAll();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _customerService.GetById(id);
            var customerAddresses = _customerAddressService.GetAllByCustomerId(id);

            if (customer == null) RedirectToAction("Index");

            var detail = new CustomerDetailsViewModel
            {
                Id = customer.Id,
                PersonType = customer.PersonType,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                NationalityType = customer.NationalityType,
                Phone = customer.Phone,
                Email = customer.Email,
                BirthDate = customer.BirthDate,

                CustomerAddresses = customerAddresses
            };

            return View(detail);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerAddViewModel model)
        {
            try
            {
                var customer = new Customer
                {
                    PersonType = model.PersonType,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    NationalityType = model.NationalityType,
                    Phone = model.Phone,
                    Email = model.Email,
                    BirthDate = model.BirthDate
                };

                _customerService.Create(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var customer = _customerService.GetById(id);

            if (customer == null) RedirectToAction("Index");

            var detail = new CustomerEditViewModel
            {
                Id = customer.Id,
                PersonType = customer.PersonType,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                NationalityType = customer.NationalityType,
                Phone = customer.Phone,
                Email = customer.Email,
                BirthDate = customer.BirthDate
            };

            return View(detail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditViewModel model)
        {
            try
            {
                var customer = new Customer
                {
                    Id = model.Id,
                    PersonType = model.PersonType,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    NationalityType = model.NationalityType,
                    Phone = model.Phone,
                    Email = model.Email,
                    BirthDate = model.BirthDate
                };

                _customerService.Update(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var customer = _customerService.GetById(id);

            if (customer == null) RedirectToAction("Index");

            var detail = new CustomerDetailsViewModel
            {
                Id = customer.Id,
                PersonType = customer.PersonType,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                NationalityType = customer.NationalityType,
                Phone = customer.Phone,
                Email = customer.Email,
                BirthDate = customer.BirthDate
            };

            return View(detail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var customer = _customerService.GetById(id);

                _customerService.Delete(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
