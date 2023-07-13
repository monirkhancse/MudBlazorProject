using MudBlazorProject.Data;

namespace MudBlazorProject.IService
{
    public interface IEmpTitleService
    {
        List<EmpTitle> GetEmpTitles();
        EmpTitle? GetEmpTitleById(int id);
        void AddEmpTitle(EmpTitle empTitle);
        void UpdateEmpTitle(EmpTitle empTitle);
        void DeleteEmpTitle(int id);
    }
}
