using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student.Models;

namespace Student.Pages
{
    public class EditModel : PageModel
    {
        public List<StudentTable> OurStudentList { get; set; }

        StoreData SD_Edit = new StoreData();
        public void OnGet()
        {
            OurStudentList = SD_Edit.StudentList;
        }
    }
}
