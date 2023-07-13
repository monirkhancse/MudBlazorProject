using Microsoft.EntityFrameworkCore;
using MudBlazorProject.ContextClass;
using MudBlazorProject.Data;
using MudBlazorProject.IService;

namespace MudBlazorProject.Service
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ApplicationDbContext _context;
        public SubCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
            _context.SaveChanges();
        }

        public void DeleteSubCategory(int id)
        {
            var subCategory = _context.SubCategories.FirstOrDefault(s => s.Id == id);
            if (subCategory != null)
            {
                _context.SubCategories.Remove(subCategory);
                _context.SaveChanges();
            }
        }

        public List<SubCategory> GetSubCategories()
        {
            return _context.SubCategories.ToList();
        }

        public SubCategory? GetSubCategoryById(int id)
        {
            return _context.SubCategories.SingleOrDefault(s => s.Id == id);
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
            _context.SaveChanges();
        }
    }
}
