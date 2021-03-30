using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


using System.Linq;
using System.Threading.Tasks;


namespace drive_truck_web.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Garage> Garage { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
    }
}
