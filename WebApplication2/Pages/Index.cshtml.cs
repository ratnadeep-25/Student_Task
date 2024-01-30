using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly StudentService _studentService;

        public IndexModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> Students { get; set; }

        public void OnGet()
        {
            Students = _studentService.GetStudents();
        }
    }
}
