using Microsoft.EntityFrameworkCore;

namespace CRMApp.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) {}

        public DbSet<Customer> Customers { get; set; }
    }
}
