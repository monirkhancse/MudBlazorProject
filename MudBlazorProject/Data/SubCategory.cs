namespace MudBlazorProject.Data
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public MudBlazorProject.Data.Category Category { get; set; }
    }
}
