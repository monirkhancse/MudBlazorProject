using MudBlazorProject.Data;

namespace MudBlazorProject.IService
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer? GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
