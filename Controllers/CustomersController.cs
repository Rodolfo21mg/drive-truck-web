using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DriveTruck.Services;
using DriveTruck.Models.ViewModels;
using DriveTruck.Models;

namespace DriveTruck.Controllers
{

    public class CustomersController : Controller
    {
        private readonly CustomerServices _customerServices;

        public CustomersController(CustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        // GET: Customers
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
     
            await _customerServices.InsertAsync(customer);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Get()
        {
            var customer = _customerServices.AllCustomers();
            return Json(customer);
        }

     
    }
}
