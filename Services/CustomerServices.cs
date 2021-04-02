using DriveTruck.Models;
using System;
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

    }
}