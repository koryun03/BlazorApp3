using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationContext _context;
        public CustomerService(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public async Task AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
