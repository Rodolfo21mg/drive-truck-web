using System;
using DriveTruck.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DriveTruck.Services
{
    public class CustomerServices
    {
        private readonly ApplicationDbContext _context;

        public CustomerServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Customer obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> AllCustomers() 
        {
            var customers =  _context.Customer.ToList();
            return customers;
        }

        public async Task<Customer> FindByIdAsync(int id)
        {
            return await _context.Customer.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task UpdateAsync(Customer obj)
        {
            bool hasAny = await _context.Customer.AnyAsync(x => x.Id == obj.Id);

            _context.Update(obj);
            await _context.SaveChangesAsync();
      
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}