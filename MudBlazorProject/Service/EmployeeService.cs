using MudBlazorProject.ContextClass;
using MudBlazorProject.Data;
using MudBlazorProject.IService;

namespace MudBlazorProject.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }  
        }

        public Employee? GetEmployeeById(int id)
        {
            return _context.Employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
