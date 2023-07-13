using MudBlazorProject.Data;

namespace MudBlazorProject.IService
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category? GetCategoryById(int id);
        void AddCategory(Category category);    
        void UpdateCategory(Category category);    
        void DeleteCategory(int id);    

    }
}
