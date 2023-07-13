using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MudBlazorProject.Data
{
    public class EmpTitle
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime CrteateDate { get; set; }

    }
}
