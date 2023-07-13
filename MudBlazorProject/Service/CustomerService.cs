using MudBlazorProject.ContextClass;
using MudBlazorProject.Data;
using MudBlazorProject.IService;

namespace MudBlazorProject.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
        public Customer? GetCustomerById(int id)
        {
           return _context.Customers.SingleOrDefault(x => x.Id == id);
        }
        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
