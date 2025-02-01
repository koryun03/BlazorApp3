namespace BlazorApp3.Data
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task AddCustomer(Customer customer);
    }
}
