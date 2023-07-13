using MudBlazorProject.Data;

namespace MudBlazorProject.IService
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetSubCategories();
        SubCategory? GetSubCategoryById(int id);
        void AddSubCategory(SubCategory subCategory);   
        void UpdateSubCategory(SubCategory subCategory);
        void DeleteSubCategory(int id);
    }
}
