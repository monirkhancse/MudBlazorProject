using MudBlazorProject.Data;

namespace MudBlazorProject.IService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee? GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }

}
