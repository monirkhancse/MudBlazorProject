using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MudBlazorProject.ContextClass;
using MudBlazorProject.Data;
using MudBlazorProject.IService;

namespace MudBlazorProject.Service
{
    public class EmpTitleService : IEmpTitleService
    {
        private readonly ApplicationDbContext _context;
        public EmpTitleService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddEmpTitle(EmpTitle empTitle)
        {
            _context.EmpTitles.Add(empTitle);
            _context.SaveChanges();
        }

        public void DeleteEmpTitle(int id)
        {
            var empTitle = _context.EmpTitles.FirstOrDefault(x=>x.ID == id);
            if (empTitle != null)
            {
                _context.EmpTitles.Remove(empTitle);
                _context.SaveChanges();
            }
        }

        public EmpTitle? GetEmpTitleById(int id)
        {
           return _context.EmpTitles.SingleOrDefault(x=>x.ID== id);
        }

        public List<EmpTitle> GetEmpTitles()
        {
            return _context.EmpTitles.ToList();
        }

        public void UpdateEmpTitle(EmpTitle empTitle)
        {
           _context.Update(empTitle);
            _context.SaveChanges();
        }
    }
}
