using AppService.Services;
using Domain.Entities;
using KnowYourCustomer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KnowYourCustomer.Controllers
{
    public class CustomerAddressController : Controller
    {
        private readonly ICustomerAddressService _customerAddressService;
        private readonly ICountryService _countryService;

        public CustomerAddressController(ICustomerAddressService customerAddressService,
            ICountryService countryService)
        {
            _customerAddressService = customerAddressService;
            _countryService = countryService;
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create(int customerId)
        {
            var viewModel = new CustomerAddressAddViewModel
            {
                CustomerId = customerId,
                Countries = _countryService.GetAll()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerAddressAddViewModel viewModel)
        {
            try
            {
                var customerAddress = new CustomerAddress
                {
                    AddressType = viewModel.AddressType,
                    City = viewModel.City,
                    CountryId = viewModel.CountryId,
                    Street = viewModel.Street,
                    ZipCode = viewModel.ZipCode,
                    IsMain = viewModel.IsMain,
                    Number = viewModel.Number,
                    Sector = viewModel.Sector,
                    Notes = viewModel.Notes,
                    CustomerId = viewModel.CustomerId
                };

                _customerAddressService.Create(customerAddress);

                return RedirectToAction("Details", "Customer", new { Id = viewModel.CustomerId });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
           var customerAddress = _customerAddressService.GetById(id);

            if (customerAddress == null) RedirectToAction("Index", "Home");

            var viewModel = new CustomerAddressAddViewModel
            {
                AddressType = customerAddress.AddressType,
                City = customerAddress.City,
                CountryId = customerAddress.CountryId,
                Street = customerAddress.Street,
                ZipCode = customerAddress.ZipCode,
                IsMain = customerAddress.IsMain,
                Number = customerAddress.Number,
                Sector = customerAddress.Sector,
                Notes = customerAddress.Notes,
                CustomerId = customerAddress.CustomerId
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var customerAddress = _customerAddressService.GetById(id);

                _customerAddressService.Delete(customerAddress);

                return RedirectToAction("Details", "Customer", new { Id = customerAddress.CustomerId });
            }
            catch
            {
                return View();
            }
        }
    }
}
