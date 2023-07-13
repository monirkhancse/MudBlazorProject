using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace MudBlazorProject.Data
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime? JoiningDate { get; set; }
        public string Department { get; set; } 
        public string Designation { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; } 
        public decimal Salary { get; set; } 
        public string Address { get; set; }
        public DateTime? CreatedDate { get; set; }= DateTime.Now;
        public bool Active { get; set; }

    }
}
