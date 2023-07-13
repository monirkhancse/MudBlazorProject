using System.ComponentModel.DataAnnotations;

namespace MudBlazorProject.Data
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The First Name field is required.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "The Last Name field is required.")]
        public string? LastName { get; set; }
        [RegularExpression(@"^\+?\d{0,2}[- ]?\d{3}[- ]?\d{3}[- ]?\d{4}$",
        ErrorMessage = "Invalid phone number.")]
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Status { get; set; }

    }
}
