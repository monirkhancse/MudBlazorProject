using System.ComponentModel.DataAnnotations;

namespace MudBlazorProject.Data
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
