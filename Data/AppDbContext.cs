using Microsoft.EntityFrameworkCore;
using RepairShopWebApplication.Models;

namespace RepairShopWebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
           public DbSet<Staff> staffs { get; set; }
           public DbSet<Customer> customers { get; set; }
           public DbSet<Fault> faults { get; set; }
           public DbSet<Bill> bills { get; set; }
        
    }

}

