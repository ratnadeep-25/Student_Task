using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demo11.Pages
{
    public class IndexModel : PageModel
    {
         private readonly StudentService _studentService;
        //private readonly ILogger<IndexModel> _logger;

        public IndexModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
         public List<Student> StudentList { get; set; }
        public void OnGet()
        {
            StudentList = _studentService.GetStudentList();
        }
    }
}
