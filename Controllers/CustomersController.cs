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
        
        [Route("Customers/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            var obj = await _customerServices.FindByIdAsync(id.Value);
     
            CustomerFormViewModel viewModel = new CustomerFormViewModel { Customer = obj};
           
            return View(viewModel);
        } 

        [Route("Customers/Show/{id}")]
        public async Task<IActionResult> Show(int? id)
        {

            var obj = await _customerServices.FindByIdAsync(id.Value);
     
            CustomerFormViewModel viewModel = new CustomerFormViewModel { Customer = obj};
           
            return View(viewModel);
        } 

        public IActionResult Get()
        {
            var customer = _customerServices.AllCustomers();
            return Json(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Customers/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            await _customerServices.UpdateAsync(customer);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        [Route("Customers/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _customerServices.RemoveAsync(id);
            return Json(new { success = true, message = "ok", status = 200 });
        }

        public IActionResult Export()
        {
            Console.WriteLine("Acessou!");
        }

        public IActionResult Import()
        {
            Console.WriteLine("Acessou!");
        }
    }
}
